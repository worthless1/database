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
    public partial class ClientForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = 
        (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT [Код пользователя] FROM Пользователи", connect);
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
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || ComboBox1.Text != "")
            {
                SqlCommand sql = new SqlCommand("INSERT Клиенты VALUES(@fam, @name, @otch, @tel, @id)", connect);
                sql.Parameters.AddWithValue("@fam", textBox1.Text);
                sql.Parameters.AddWithValue("@name", textBox2.Text);
                sql.Parameters.AddWithValue("@otch", textBox3.Text);
                sql.Parameters.AddWithValue("@tel", textBox4.Text);
                sql.Parameters.AddWithValue("@id", ComboBox1.Text);
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
