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
    public partial class UpClientForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = 
        (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        public UpClientForm(string id)
        {
            InitializeComponent();
            labId.Text = id;
        }

        private void UpClientForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Клиенты WHERE [Код клиента] = @id", connect);
            sql.Parameters.AddWithValue("@id", Convert.ToInt32(labId.Text));
            SqlCommand sql1 = new SqlCommand("SELECT * FROM Пользователи", connect);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox1.Text = Convert.ToString(reader.GetValue(1));
                    textBox2.Text = Convert.ToString(reader.GetValue(2));
                    textBox3.Text = Convert.ToString(reader.GetValue(3));
                    textBox4.Text = Convert.ToString(reader.GetValue(4));
                    ComboBox1.Items.Insert(0, Convert.ToString(reader.GetValue(5)));
                }
            }
            reader.Close();
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
            ComboBox1.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || ComboBox1.Text != "")
            {
                SqlCommand sql = new SqlCommand("UPDATE Клиенты SET [Фамилия] = @fam, [Имя] = @name, [Отчество] = @otch, [Телефон] = @tel ,[Код пользователя] = @id WHERE [Код клиента] = @stroka", connect);
                sql.Parameters.AddWithValue("@fam", textBox1.Text);
                sql.Parameters.AddWithValue("@name", textBox2.Text);
                sql.Parameters.AddWithValue("@otch", textBox3.Text);
                sql.Parameters.AddWithValue("@tel", textBox4.Text);
                sql.Parameters.AddWithValue("@id", ComboBox1.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись была успешно в базе данных была успешно изменена", "Изменение записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
