using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace programm
{
    public partial class IspDetForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = 
        (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        public IspDetForm()
        {
            InitializeComponent();
        }

        private void IspDetForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Заказы", connect);
            SqlCommand sql1 = new SqlCommand("SELECT * FROM Склад", connect);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            reader = sql1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox2.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" || textBox1.Text != "" || comboBox2.Text != "")
            {
                SqlCommand sql = new SqlCommand("INSERT [Использованные детали] VALUES(@id, @det, @kolvo)", connect);
                sql.Parameters.AddWithValue("@id", comboBox1.Text);
                sql.Parameters.AddWithValue("@det", comboBox2.Text);
                sql.Parameters.AddWithValue("@kolvo", textBox1.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись была успешно добавлена в базу данных", "Добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Заполните все поля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
