using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ресторан_проект.LoginForm;

namespace ресторан_проект
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

        }
        private void registerButton_Click_1(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            UserRole role = UserRole.Client;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            if (AuthService.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return;
            }
            AuthService.Register(username, password, role);
            MessageBox.Show("Регистрация прошла успешно!");
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
