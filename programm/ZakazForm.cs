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
    public partial class ZakazForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public ZakazForm()
        {
            InitializeComponent();
        }

        private void ZakazForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Клиенты", connect);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ComboBox1.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ComboBox1.Text != "" || textBox1.Text != "" || ComboBox2.Text != "")
            {
                //Если заказ имеет статус "В работе" то дата закрытия отсутсвует
                SqlCommand sql;
                if (ComboBox2.Text == "В работе")
                    sql = new SqlCommand("INSERT INTO Заказы(Код_клиента, Дата_заказа, Описание, Статус) VALUES(@id, @datez, @opis, @st)", connect);
                else
                {
                    sql = new SqlCommand("INSERT Заказы VALUES(@id, @datez, @opis, @st, @dataz)", connect);
                    sql.Parameters.AddWithValue("@dataz", DateBox2.Value);
                }
                sql.Parameters.AddWithValue("@id", ComboBox1.Text);
                sql.Parameters.AddWithValue("@datez", DateBox1.Value);
                sql.Parameters.AddWithValue("@opis", textBox1.Text);
                sql.Parameters.AddWithValue("@st", ComboBox2.Text);
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

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox2.Text == "В работе")
                DateBox2.Enabled = false;
            else
                DateBox2.Enabled = true;
        }
    }
}