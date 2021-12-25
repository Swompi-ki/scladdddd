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
    public partial class Manu : Form
    {
        public Manu()
        {
            InitializeComponent();
            get_Info(List);
        }
        //Автоматическое заполнение данных List  
        void get_Info(ListView List)
        {
            string query = "select material.ID, material.Title, material.Unit, material.Image from material;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Удаление данных по №/ID 
        private void Del_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            string query = "delete from k_info where Id = " + List.Items[List.SelectedIndices[0]].Text + ";";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Обновить данные в таблице
        private void Tap_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            get_Info(List);
        }

        //Поиск данных 
        private void button1_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
            //string query = "SELECT*FROM k_info where Godvipuska = '" + textBox1.Text + "';";
            string quryF = "select * from material where concat(Title, Unit, Image) like '%" + textBox1.Text + "%'";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(quryF, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                        var listItem = new ListViewItem(row);
                        List.Items.Add(listItem);
                    }
                }
                List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Home win = new Home();
            win.Show();
            this.Hide();
        }
        //Кнопкадобавления данных в форме AddManu
        private void AddMenu_Click(object sender, EventArgs e)
        {
            AddManu Win = new AddManu();
            Win.Show();
            this.Hide();
        }

        private void DelManu_Click(object sender, EventArgs e)
        {
            //не работает изменение данных
            AddManu Win = new AddManu();
            Win.Show();
            this.Hide();
        }
    }
}
