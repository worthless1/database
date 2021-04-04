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
    public partial class UpOkUslForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public UpOkUslForm(string id)
        {
            InitializeComponent();
            labId.Text = id;
        }

        private void UpOkUslForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT [Номер заказа] FROM Заказы", connect);
            SqlCommand sql1 = new SqlCommand("SELECT [Код сотрудника] FROM Сотрудники", connect);
            SqlCommand sql2 = new SqlCommand("SELECT [Код услуги] FROM Услуги", connect);
            SqlCommand sql3 = new SqlCommand("SELECT * FROM [Оказанные_услуги] WHERE [Код ОУ] = @id", connect);
            sql3.Parameters.AddWithValue("@id", Convert.ToInt32(labId.Text));

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

            reader = sql3.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBox1.Text = Convert.ToString(reader.GetValue(1));
                    comboBox2.Text = Convert.ToString(reader.GetValue(2));
                    dateBox3.Value = Convert.ToDateTime(reader.GetValue(3));
                    comboBox4.Text = Convert.ToString(reader.GetValue(4));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" || comboBox4.Text != "" || comboBox2.Text != "")
            {
                SqlCommand sql = new SqlCommand("UPDATE [Оказанные_услуги] SET [Номер заказа] = @id1, [Код сотрудника] = @id2, [Дата] = @dateu, [Код услуги] = @id3 WHERE [Код ОУ] = @stroka", connect);
                sql.Parameters.AddWithValue("@id1", comboBox1.Text);
                sql.Parameters.AddWithValue("@id2", comboBox2.Text);
                sql.Parameters.AddWithValue("@dateu", dateBox3.Value);
                sql.Parameters.AddWithValue("@id3", comboBox4.Text);
                sql.Parameters.AddWithValue("@stroka", labId.Text);
                connect.Open();
                sql.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Запись в базе данных была успешно изменена", "Изменение записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
