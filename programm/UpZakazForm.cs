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
    public partial class UpZakazForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public UpZakazForm(string id)
        {
            InitializeComponent();
            metroLabel6.Text = id;
        }

        private void UpZakazForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Заказы WHERE [Номер заказа] = @id", connect);
            sql.Parameters.AddWithValue("@id", Convert.ToInt32(metroLabel6.Text));
            SqlCommand sql1 = new SqlCommand("SELECT * FROM Клиенты", connect);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ComboBox1.Items.Insert(0, Convert.ToString(reader.GetValue(1)));
                    DateBox1.Value = Convert.ToDateTime(reader.GetValue(2));
                    textBox1.Text = Convert.ToString(reader.GetValue(3));
                    if (reader.GetValue(5) is DBNull)
                    {
                        DateBox2.Value = DateTime.Now;
                        DateBox2.Enabled = false;
                    }
                    else
                    {
                        DateBox2.Value = Convert.ToDateTime(reader.GetValue(5));
                    }
                    ComboBox2.Items.Insert(0, Convert.ToString(reader.GetValue(4))); 
                }
            }
            reader.Close();
            ComboBox1.SelectedIndex = 0;
            ComboBox2.SelectedIndex = 0;
            reader = sql1.ExecuteReader();
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
                SqlCommand sql;
                if (ComboBox2.Text == "В работе")
                {
                    sql = new SqlCommand("UPDATE Заказы SET [Код клиента] = @id, [Дата заказа] = @datez, [Описание] = @opis, [Статус] = @st WHERE [Номер заказа] = @stroka", connect);
                }
                else
                {
                    sql = new SqlCommand("UPDATE Заказы SET [Код клиента] = @id, [Дата заказа] = @datez, [Описание] = @opis, [Статус] = @st, [Дата закрытия] = @dataz WHERE [Номер заказа] = @stroka", connect);
                    sql.Parameters.AddWithValue("@dataz", DateBox2.Value);
                }               
                sql.Parameters.AddWithValue("@id", ComboBox1.Text);
                sql.Parameters.AddWithValue("@datez", DateBox1.Value);
                sql.Parameters.AddWithValue("@opis", textBox1.Text);
                sql.Parameters.AddWithValue("@st", ComboBox2.Text);
                sql.Parameters.AddWithValue("@stroka", metroLabel6.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись была успешно в базе данных была успешно изменена", "Изменение записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else 
                MessageBox.Show("Заполните все поля", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox2.Text == "В работе") DateBox2.Enabled = false;           
            else DateBox2.Enabled = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
