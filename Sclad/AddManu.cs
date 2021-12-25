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
    public partial class AddManu : Form
    {
        public AddManu()
        {
            InitializeComponent();
        }

        //Добавление данных в таблицу на List
        private void AddButton_Click(object sender, EventArgs e)
        {
            {
                string query = "insert into material(Title, Unit, Image) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}

