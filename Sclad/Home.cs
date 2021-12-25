using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sclad
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Click_Click(object sender, EventArgs e)
        {
            label1.Text = "Здравствуйте сегодня вы увидите мое приложение склад товаров";
        }

        //кнопка перехода наформу Manu
        private void Meni_Click(object sender, EventArgs e)
        {
            Manu win = new Manu();
            win.Show();
            this.Hide();

        }
    }
}
