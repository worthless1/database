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
    public partial class UpIspDetForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public UpIspDetForm(string id)
        {
            InitializeComponent();
            labId.Text = id;
        }

        private void UpIspDetForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Использованные_детали WHERE Код_детали = @id", connect);
            sql.Parameters.AddWithValue("@id", Convert.ToInt32(labId.Text));
            SqlCommand sql1 = new SqlCommand("SELECT * FROM Заказы", connect);
            SqlCommand sql2 = new SqlCommand("SELECT * FROM Склад", connect);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {                   
                    comboBox1.Items.Insert(0, Convert.ToString(reader.GetValue(1)));
                    comboBox2.Items.Insert(0, Convert.ToString(reader.GetValue(2)));
                    textBox3.Text = Convert.ToString(reader.GetValue(3));

                }
            }
            reader.Close();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            reader = sql1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            reader = sql2.ExecuteReader();
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
            if (comboBox1.Text != "" || textBox3.Text != "" || comboBox2.Text != "")
            {
                SqlCommand sql = new SqlCommand("UPDATE Использованные_детали SET Номер_заказа = @id, Код_детали = @det, Количество = @kolvo WHERE Код_ИД = @stroka", connect);
                sql.Parameters.AddWithValue("@id", comboBox1.Text);
                sql.Parameters.AddWithValue("@det", comboBox2.Text);
                sql.Parameters.AddWithValue("@kolvo", textBox3.Text);
                sql.Parameters.AddWithValue("@stroka", labId.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись в базе данных была успешно изменена", "Изменение записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Заполните все поля", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ввод в окно количество только цифр и использование служебных кнопок
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
