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
using System.Security.Cryptography;

namespace programm
{
    public partial class UpPolzForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = 
        (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        public UpPolzForm(string id)
        {
            InitializeComponent();
            labId.Text = id;
        }

        private void UpPolzForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Пользователи WHERE [Код пользователя] = @id", connect);
            sql.Parameters.AddWithValue("@id", Convert.ToInt32(labId.Text));
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox1.Text = Convert.ToString(reader.GetValue(1));
                    ComboBox3.Text = Convert.ToString(reader.GetValue(3));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || ComboBox3.Text != "")
            {
                SqlCommand sql = new SqlCommand("UPDATE Пользователи SET [Логин] = @log, [Пароль] = @pass, [Уровень_доступа] = @role WHERE [Код пользователя] = @stroka", connect);
                sql.Parameters.AddWithValue("@log", textBox1.Text);
                sql.Parameters.AddWithValue("@pass", getHashSha256(textBox2.Text));
                sql.Parameters.AddWithValue("@role", ComboBox3.Text);
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

        private string getHashSha256(string text)
        {
            //Хэширование пароля
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString.ToString();
        }
    }
}
