using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Text.Json;
using System.Text;


namespace ресторан_проект
{
    public partial class LoginForm : Form
    {
        public enum UserRole { Admin, Employee, Client }

        public class User
        {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public UserRole Role { get; set; }
        }

        public class AuthService
        {
            private static string filePath = "users.json";
            public static List<User> Users { get; private set; } = new List<User>();

            static AuthService()
            {
                LoadUsers();
            }

            public static void Register(string username, string password, UserRole role)
            {
                var user = new User
                {
                    Id = Users.Count + 1,
                    Username = username,
                    Password = HashPassword(password),
                    Role = role
                };
                Users.Add(user);
                SaveUsers();
            }


            public static User Login(string username, string password)
            {
                string hashedPassword = HashPassword(password);
                return Users.FirstOrDefault(u =>u.Username == username && u.Password == hashedPassword);
            }

            private static void LoadUsers()
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    Users = JsonSerializer.Deserialize<List<User>>(json);
                }
                else
                {
                    Users = new List<User>();
                }
            }

            public static void SaveUsers()
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                File.WriteAllText(filePath, JsonSerializer.Serialize(Users, options));

            }
        }

        public LoginForm()
        {
            InitializeComponent();
            LoadAdress();
        }

        private static string HashPassword(string password)
        {
            using var sha256 = System.Security.Cryptography.SHA256.Create();
            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashedBytes);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void registerButton_Click_1(object sender, EventArgs e)
        {
            var regForm = new RegisterForm();
            this.Hide();
            regForm.ShowDialog();
            this.Show(); 
        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            var user = AuthService.Login(usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Неверные данные");
                return;
            }
            Form nextForm = null;
            switch (user.Role)
            {
                case UserRole.Admin:
                    nextForm = new AdminPanelForm(user);
                    break;
                case UserRole.Employee:
                    nextForm = new Choisebord(user);
                    break;
                case UserRole.Client:
                    nextForm = new MenuForm(user);
                    break;
            }

            if (nextForm != null)
            {
                nextForm.FormClosed += (s, args) => this.Show();
                nextForm.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void label1_Click(object sender, EventArgs e)
        {
           
        }

        public async void LoadAdress()
        {
            string apiKey = "591342e04835431bb830c04670e8ebe6";
            int number = 1;
            string culture = "ru";
            string url = $"https://randommer.io/api/Misc/Random-Address?number={number}&culture={culture}";

            using HttpClient client = new();
            client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
            HttpResponseMessage resp = client.GetAsync(url).Result;
            string result = await resp.Content.ReadAsStringAsync();
            adress.Text = result;
        }


    }
}