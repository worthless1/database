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
    public partial class ManageZakazForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = 
            (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        public ManageZakazForm()
        {
            InitializeComponent();
            Rfrsh(this, EventArgs.Empty);
        }

        private void Rfrsh(object sender, EventArgs e)
        {
            ComboBox1.Items.Clear();
            textBox1.Clear();
            listBox.Clear();
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Clear();
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Клиенты WHERE [Код клиента] = @id", connect);
            sql.Parameters.AddWithValue("@id", ComboBox1.Text);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listBox.Items.Add(Convert.ToString("Фамилия: " + reader.GetValue(1)));
                    listBox.Items.Add(Convert.ToString("Имя: " + reader.GetValue(2)));
                    listBox.Items.Add(Convert.ToString("Отчество: " + reader.GetValue(3)));
                    listBox.Items.Add(Convert.ToString("Телефон: " + reader.GetValue(4)));
                }
            }
            reader.Close();
            connect.Close();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ClientForm Cli = new ClientForm();
            Cli.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("INSERT INTO Заказы([Код клиента], [Дата заказа], Описание, Статус) VALUES(@id, @datez, @opis, @st)", connect);
            sql.Parameters.AddWithValue("@id", ComboBox1.Text);
            sql.Parameters.AddWithValue("@datez", DateTime.Now);
            sql.Parameters.AddWithValue("@opis", textBox1.Text);
            sql.Parameters.AddWithValue("@st", "В работе");
            connect.Open();
            sql.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Заказ оформлен", "Оформление заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
