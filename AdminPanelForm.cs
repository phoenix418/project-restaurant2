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
    public partial class AdminPanelForm : Form
    {
        private User currentUser;

        public AdminPanelForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void RefreshUserList()
        {
            listBoxUsers.Items.Clear();
            foreach (var user in AuthService.Users)
            {
                listBoxUsers.Items.Add($"{user.Id}: {user.Username} ({user.Role})");
            }
        }

        private void buttonAddEmployee_Click_1(object sender, EventArgs e)
        {
            AddUser(UserRole.Employee);
        }

        private void buttonAddAdmin_Click_1(object sender, EventArgs e)
        {
            AddUser(UserRole.Admin);
        }

        private void AddUser(UserRole role)
        {
            string username = Prompt.ShowDialog("Введите имя пользователя:", "Добавить пользователя");
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Имя пользователя не может быть пустым.");
                return;
            }
            if (AuthService.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return;
            }
            string password = Prompt.ShowDialog("Введите пароль:", "Добавить пользователя");
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пароль не может быть пустым.");
                return;
            }
            AuthService.Register(username, password, role);
            MessageBox.Show($"Пользователь '{username}' с ролью {role} успешно добавлен.");
            RefreshUserList();
        }

        private void buttonSearchUser_Click_1(object sender, EventArgs e)
        {
            string searchTerm = Prompt.ShowDialog("Введите имя пользователя для поиска:", "Поиск пользователя");
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Поле поиска не может быть пустым.");
                return;
            }
            listBoxUsers.Items.Clear();
            // Ищем пользователей и добавляем в listBox
            var foundUsers = AuthService.Users.Where(u => u.Username.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
            if (foundUsers.Count == 0)
            {
                MessageBox.Show("Пользователи не найдены.");
            }
            else
            {
                foreach (var user in foundUsers)
                {
                    listBoxUsers.Items.Add($"{user.Id}: {user.Username} ({user.Role})");
                }
            }
        }

        private void buttonDeleteUser_Click_1(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите пользователя из списка.");
                return;
            }   // Парсим ID пользователя из выбранного элемента
            string selectedItem = listBoxUsers.SelectedItem.ToString();
            if (!int.TryParse(selectedItem.Split(':')[0], out int userId))
            {
                MessageBox.Show("Ошибка при получении ID пользователя.");
                return;
            }
            var userToRemove = AuthService.Users.FirstOrDefault(u => u.Id == userId);
            if (userToRemove == null)
            {
                MessageBox.Show("Пользователь не найден.");
                return;
            }
            if (userToRemove.Id == currentUser.Id)
            {
                MessageBox.Show("Нельзя удалить текущего пользователя.");
                return;
            }
            // Подтверждение удаления
            var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить пользователя {userToRemove.Username}?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                AuthService.Users.Remove(userToRemove);
                AuthService.SaveUsers();
                MessageBox.Show($"Пользователь {userToRemove.Username} удалён.");
                // Обновляем список
                listBoxUsers.Items.RemoveAt(listBoxUsers.SelectedIndex);
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 200,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
                Button confirmation = new Button() { Text = "ОК", Left = 280, Width = 80, Top = 100, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;
                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
            }
        }
    }
    
}