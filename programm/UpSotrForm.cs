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
    public partial class UpSotrForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = 
        (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        public UpSotrForm(string id)
        {
            InitializeComponent();
            labId.Text = id;
        }

        private void UpSotrForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Сотрудники WHERE [Код сотрудника] = @id", connect);
            sql.Parameters.AddWithValue("@id", Convert.ToInt32(labId.Text));

            SqlCommand sql1 = new SqlCommand("SELECT [Код пользователя] FROM Пользователи", connect);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox1.Text = Convert.ToString(reader.GetValue(1));
                    textBox2.Text = Convert.ToString(reader.GetValue(2));
                    textBox3.Text = Convert.ToString(reader.GetValue(3));
                    comboBox4.Items.Insert(0, Convert.ToString(reader.GetValue(4)));
                    textBox5.Text = Convert.ToString(reader.GetValue(5));
                    comboBox6.Items.Insert(0, Convert.ToString(reader.GetValue(6)));

                }
            }
            reader.Close();
            comboBox4.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;

            reader = sql1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox6.Items.Add(Convert.ToString(reader.GetValue(0)));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || comboBox4.Text != "" || textBox5.Text != "" || comboBox6.Text != "")
            {
                SqlCommand sql = new SqlCommand("UPDATE Сотрудники SET [Фамилия] = @fam, [Имя] = @name, [Отчество] = @otch, [Должность] = @dol, [Адрес] = @add, [Код пользователя] = @id WHERE [Код сотрудника] = @stroka", connect);
                sql.Parameters.AddWithValue("@fam", textBox1.Text);
                sql.Parameters.AddWithValue("@name", textBox2.Text);
                sql.Parameters.AddWithValue("@otch", textBox3.Text);
                sql.Parameters.AddWithValue("@dol", comboBox4.Text);
                sql.Parameters.AddWithValue("@add", textBox5.Text);
                sql.Parameters.AddWithValue("@id", comboBox6.Text);
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
    }
}
