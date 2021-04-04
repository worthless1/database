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
    public partial class UpSkladForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public UpSkladForm(string id)
        {
            InitializeComponent();
            labId.Text = id;
        }
        private void UpSkladForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Склад WHERE [Код детали] = @id", connect);
            sql.Parameters.AddWithValue("@id", Convert.ToInt32(labId.Text));
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox1.Text = Convert.ToString(reader.GetValue(1));
                    textBox2.Text = Convert.ToString(reader.GetValue(2));
                    textBox3.Text = Convert.ToString(reader.GetValue(3));
                }
            }
            reader.Close();
            connect.Close();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "")
            {
                SqlCommand sql = new SqlCommand("UPDATE Склад SET [Наименование] = @naim, [Цена] = @cena, [Осталось] = @ost WHERE [Код детали] = @stroka", connect);
                sql.Parameters.AddWithValue("@naim", textBox1.Text);
                sql.Parameters.AddWithValue("@cena", textBox2.Text);
                sql.Parameters.AddWithValue("@ost", textBox3.Text);
                sql.Parameters.AddWithValue("@stroka", labId.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись в базе данных была успешно изменена", "Изменение записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Заполните все поля", "Ошибка измененеия", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
