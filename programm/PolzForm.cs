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
    public partial class PolzForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public PolzForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string pass = getHashSha256(textBox2.Text);
            if (textBox1.Text != "" || textBox2.Text != "" || ComboBox3.Text != "")
            {
                SqlCommand sql = new SqlCommand("INSERT Пользователи VALUES(@log, @pass, @role)", connect);
                sql.Parameters.AddWithValue("@log", textBox1.Text);
                sql.Parameters.AddWithValue("@pass", pass);
                sql.Parameters.AddWithValue("@role", ComboBox3.Text);
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
