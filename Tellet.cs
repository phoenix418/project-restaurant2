using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ресторан_проект.LoginForm;

namespace ресторан_проект
{
    public partial class Teller : Form
    {
        private static string completedOnlinePath = "deleteonl.json";
        private static string completedOfflinePath = "deleteoffl.json";
        public static class OrderService
        {
            private static string filePath = "ordersoffl.json"; // Файл для хранения заказов
            public static Dictionary<int, List<Order>> UserOrders { get; private set; } = new Dictionary<int, List<Order>>();
            static OrderService()
            {
                LoadOrders();  // При запуске загружаем сохраненные заказы
            }
            // Добавить новый заказ
            public static void AddOrder(int userId, string description)
            {
                if (!UserOrders.TryGetValue(userId, out var orders)) // Если у пользователя еще нет заказов, создаем для него список
                {
                    orders = new List<Order>();
                    UserOrders[userId] = orders;
                }
                // Создаем новый заказ
                orders.Add(new Order
                {
                    Id = orders.Count > 0 ? orders.Max(o => o.Id) + 1 : 1, // Автоматически назначаем ID
                    UserId = userId,
                    Description = description
                });

                SaveOrders();
            }

            // Изменить заказ
            public static void EditOrder(int userId, int orderId, string newDescription)
            {
                // Находим заказ пользователя и обновляем описание
                if (UserOrders.TryGetValue(userId, out var orders))
                {
                    var order = orders.FirstOrDefault(o => o.Id == orderId);
                    if (order != null)
                    {
                        order.Description = newDescription;
                        SaveOrders();
                    }
                }
            }

            // Удалить заказ
            public static void DeleteOrder(int userId, int orderId)
            {
                // Находим и удаляем заказ
                if (UserOrders.TryGetValue(userId, out var orders))
                {
                    var order = orders.FirstOrDefault(o => o.Id == orderId);
                    if (order != null && orders.Remove(order))
                    {
                        SaveOrders();
                    }
                }
            }

            // Загрузить заказы из файла
            private static void LoadOrders()
            {
                try
                {
                    UserOrders = File.Exists(filePath)
                        ? JsonSerializer.Deserialize<Dictionary<int, List<Order>>>(File.ReadAllText(filePath))
                        ?? new Dictionary<int, List<Order>>()
                        : new Dictionary<int, List<Order>>();
                }
                catch
                {
                    UserOrders = new Dictionary<int, List<Order>>();
                }

            }

            // Сохранить заказы в файл
            private static void SaveOrders()
            {
                File.WriteAllText(filePath, JsonSerializer.Serialize(UserOrders, new JsonSerializerOptions { WriteIndented = true }));
            }
        }

        public class Order
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
        }

        private User currentUser;
        public Teller(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void Teller_Load(object sender, EventArgs e)
        {
            RefreshOrderList();
            LoadOnlineOrders();
            LoadCompletedOrders(); 
        }

        private void LoadCompletedOrders()
        {
            listBoxOnlineOrders.Items.Clear();
            listBoxOfflineOrders.Items.Clear();

            // Загрузка выполненных онлайн-заказов
            if (File.Exists(completedOnlinePath))
            {
                var completedOnlineOrders = JsonSerializer.Deserialize<Dictionary<int, List<CompletedOrder>>>(File.ReadAllText(completedOnlinePath));
                foreach (var userOrders in completedOnlineOrders)
                {
                    foreach (var order in userOrders.Value)
                    {
                        listBoxOnlineOrders.Items.Add($"[Выполнен] User {order.UserId}: {order.Description} ({order.CompletionDate})");
                    }
                }
            }

            // Загрузка выполненных оффлайн-заказов
            if (File.Exists(completedOfflinePath))
            {
                var completedOfflineOrders = JsonSerializer.Deserialize<Dictionary<int, List<CompletedOrder>>>(File.ReadAllText(completedOfflinePath));
                foreach (var userOrders in completedOfflineOrders)
                {
                    foreach (var order in userOrders.Value)
                    {
                        listBoxOfflineOrders.Items.Add($"[Выполнен] User {order.UserId}: {order.Description} ({order.CompletionDate})");
                    }
                }
            }
        }

        public class CompletedOrder
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
            public DateTime CompletionDate { get; set; }
        }


        private void RefreshOrderList()
        {
            listBoxOrders.Items.Clear();

            foreach (var userOrders in OrderService.UserOrders)
            {
                foreach (var order in userOrders.Value)
                {
                    listBoxOrders.Items.Add($"{order.Description}");
                }
            }
        }

        private void LoadOnlineOrders()
        {
            listBoxOrdersonl.Items.Clear();
            if (File.Exists("ordersonl.json"))
            {
                var onlineOrders = JsonSerializer.Deserialize<Dictionary<int, List<OnlineOrder>>>(File.ReadAllText("ordersonl.json"));
                foreach (var userOrders in onlineOrders)
                {
                    foreach (var order in userOrders.Value)
                    {
                        listBoxOrdersonl.Items.Add($"[User {order.UserId}] {order.Description}");
                    }
                }
            }
        }



        public static class Prompt
        {
            public static string ShowDialog(string text, string caption, string defaultText = "")
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 180,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };
                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 340 };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = defaultText };
                Button confirmation = new Button() { Text = "ОК", Left = 280, Width = 80, Top = 90, DialogResult = DialogResult.OK };
                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedIndex >= 0)
            {
                // Находим выбранный заказ среди всех заказов
                var selectedText = listBoxOrders.SelectedItem.ToString();
                foreach (var userOrders in OrderService.UserOrders)
                {
                    foreach (var order in userOrders.Value.ToList())
                    {
                        if ($"[User {order.UserId}] {order.Description}" == selectedText)
                        {
                            OrderService.DeleteOrder(order.UserId, order.Id);
                            MessageBox.Show("Заказ удалён.");
                            RefreshOrderList();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления.");
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            // Показываем диалог для ввода описания
            string description = Prompt.ShowDialog("Введите описание заказа:", "Добавить заказ");

            if (!string.IsNullOrWhiteSpace(description))
            {
                OrderService.AddOrder(currentUser.Id, description);
                MessageBox.Show("Заказ добавлен.");
                RefreshOrderList();
            }
            else
            {
                MessageBox.Show("Описание заказа не может быть пустым.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedIndex >= 0) // Если заказ выбран
            {
                var selectedOrder = OrderService.UserOrders[currentUser.Id][listBoxOrders.SelectedIndex];
                // Показываем диалог с текущим описанием
                string newDescription = Prompt.ShowDialog("Введите новое описание:", "Редактировать заказ", selectedOrder.Description);

                if (!string.IsNullOrWhiteSpace(newDescription))
                {
                    OrderService.EditOrder(currentUser.Id, selectedOrder.Id, newDescription);
                    MessageBox.Show("Заказ обновлён.");
                    RefreshOrderList();
                }
                else
                {
                    MessageBox.Show("Описание не может быть пустым.");
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ для редактирования.");
            }
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOrdersonl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public class OnlineOrder
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
            public DateTime OrderDate { get; set; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBoxOnlineOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOfflineOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}