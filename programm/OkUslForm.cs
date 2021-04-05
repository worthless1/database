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
    public partial class OkUslForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public OkUslForm()
        {
            InitializeComponent();
        }

        private void OkUslForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT Номер_заказа FROM Заказы", connect);
            SqlCommand sql1 = new SqlCommand("SELECT Код_сотрудника FROM Сотрудники", connect);
            SqlCommand sql2 = new SqlCommand("SELECT Код_услуги FROM Услуги", connect);
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
            reader = sql2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox4.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" || comboBox4.Text != "" || comboBox2.Text != "")
            {
                SqlCommand sql = new SqlCommand("INSERT Оказанные_услуги VALUES(@id1, @id2, @dateu, @id3)", connect);
                sql.Parameters.AddWithValue("@id1", comboBox1.Text);
                sql.Parameters.AddWithValue("@id2", comboBox2.Text);
                sql.Parameters.AddWithValue("@dateu", dateBox1.Value);
                sql.Parameters.AddWithValue("@id3", comboBox4.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись была успешно добавлена в базу данных", "Добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Заполните все поля", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
