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
    public partial class сook : Form
    {
        private string onlineOrdersPath = "ordersonl.json";
        private string offlineOrdersPath = "ordersoffl.json";
        private string completedOnlinePath = "deleteonl.json";
        private string completedOfflinePath = "deleteoffl.json";
        private User currentUser;
        public сook(User currentUser)
        {
            InitializeComponent();
            LoadOrders();
            this.currentUser = currentUser;
        }

        private void LoadOrders()
        {
            listBoxOnlineOrders.Items.Clear();
            if (File.Exists(onlineOrdersPath))
            {
                var onlineOrders = JsonSerializer.Deserialize<Dictionary<int, List<OnlineOrder>>>(File.ReadAllText(onlineOrdersPath));
                foreach (var userOrders in onlineOrders)
                {
                    foreach (var order in userOrders.Value)
                    {
                        listBoxOnlineOrders.Items.Add($"[ID:{order.Id}] User {order.UserId}: {order.Description}");
                    }
                }
            }

            listBoxOfflineOrders.Items.Clear();
            if (File.Exists(offlineOrdersPath))
            {
                var offlineOrders = JsonSerializer.Deserialize<Dictionary<int, List<Order>>>(File.ReadAllText(offlineOrdersPath));
                foreach (var userOrders in offlineOrders)
                {
                    foreach (var order in userOrders.Value)
                    {
                        listBoxOfflineOrders.Items.Add($"[ID:{order.Id}] User {order.UserId}: {order.Description}");
                    }
                }
            }
        }

        private void btnCompleteOnline_Click_1(object sender, EventArgs e)
        {
            if (listBoxOnlineOrders.SelectedItem == null)
            {
                MessageBox.Show("Выберите заказ для отметки о выполнении", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedOrderText = listBoxOnlineOrders.SelectedItem.ToString();
            if (File.Exists(onlineOrdersPath))
            {
                var onlineOrders = JsonSerializer.Deserialize<Dictionary<int, List<OnlineOrder>>>(File.ReadAllText(onlineOrdersPath));

                // Находим и удаляем выбранный заказ
                bool found = false;
                foreach (var userOrders in onlineOrders.ToList())
                {
                    foreach (var order in userOrders.Value.ToList())
                    {
                        if ($"[ID:{order.Id}] User {order.UserId}: {order.Description}" == selectedOrderText)
                        {
                            // Сохраняем в выполненные
                            SaveCompletedOrder(order, true);

                            // Удаляем из текущих
                            userOrders.Value.Remove(order);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }

                if (found)
                {
                    // Сохраняем  заказы
                    File.WriteAllText(onlineOrdersPath, JsonSerializer.Serialize(onlineOrders, new JsonSerializerOptions { WriteIndented = true }));
                    MessageBox.Show("Заказ отмечен как выполненный", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();
                }
            }
        }

        private void btnCompleteOffline_Click_1(object sender, EventArgs e)
        {
            if (listBoxOfflineOrders.SelectedItem == null)
            {
                MessageBox.Show("Выберите заказ для отметки о выполнении", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedOrderText = listBoxOfflineOrders.SelectedItem.ToString();
            if (File.Exists(offlineOrdersPath))
            {
                var offlineOrders = JsonSerializer.Deserialize<Dictionary<int, List<Order>>>(File.ReadAllText(offlineOrdersPath));

                // Находим и удаляем выбранный заказ
                bool found = false;
                foreach (var userOrders in offlineOrders.ToList())
                {
                    foreach (var order in userOrders.Value.ToList())
                    {
                        if ($"[ID:{order.Id}] User {order.UserId}: {order.Description}" == selectedOrderText)
                        {
                            // Сохраняем в выполненные
                            SaveCompletedOrder(order, false);

                            // Удаляем из текущих
                            userOrders.Value.Remove(order);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }

                if (found)
                {
                    // Сохраняем обновленные заказы
                    File.WriteAllText(offlineOrdersPath, JsonSerializer.Serialize(offlineOrders, new JsonSerializerOptions { WriteIndented = true }));
                    MessageBox.Show("Заказ отмечен как выполненный", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOrders();
                }
            }
        }

        private void SaveCompletedOrder(object order, bool isOnline)
        {
            Dictionary<int, List<CompletedOrder>> completedOrders;
            string filePath = isOnline ? completedOnlinePath : completedOfflinePath;

            try
            {
                completedOrders = File.Exists(filePath) ? JsonSerializer.Deserialize<Dictionary<int, List<CompletedOrder>>>(File.ReadAllText(filePath)) : new Dictionary<int, List<CompletedOrder>>();
            }
            catch
            {
                completedOrders = new Dictionary<int, List<CompletedOrder>>();
            }

            var completedOrder = new CompletedOrder
            {
                Id = isOnline ? ((OnlineOrder)order).Id : ((Order)order).Id,
                UserId = isOnline ? ((OnlineOrder)order).UserId : ((Order)order).UserId,
                Description = isOnline ? ((OnlineOrder)order).Description : ((Order)order).Description,
                CompletionDate = DateTime.Now
            };

            if (!completedOrders.ContainsKey(completedOrder.UserId))
            {
                completedOrders[completedOrder.UserId] = new List<CompletedOrder>();
            }

            completedOrders[completedOrder.UserId].Add(completedOrder);
            File.WriteAllText(filePath, JsonSerializer.Serialize(completedOrders, new JsonSerializerOptions { WriteIndented = true }));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        public class CompletedOrder
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Description { get; set; }
            public DateTime CompletionDate { get; set; }
        }

        private void сook_Load(object sender, EventArgs e)
        {

        }
    }

    public class OnlineOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}