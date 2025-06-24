using System;
using System.Windows.Forms;
using static ресторан_проект.LoginForm;

namespace ресторан_проект
{
    public partial class Choisebord : Form
    {
        private readonly User currentUser;

        public Choisebord(User user)
        {

            InitializeComponent();
            currentUser = user; ;
        }

        private void OpenForm(Form form)
        {
            if (form == null) return;

            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new Teller(currentUser));
        }

        private void Choisebord_Load(object sender, EventArgs e)
        {

        }

        private void Choisebord_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenForm(new сook(currentUser));
        }
    }
}