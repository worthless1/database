﻿using System;
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
    public partial class SotrForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(Properties.Settings.Default.con);
        public SotrForm()
        {
            InitializeComponent();
        }

        private void SotrForm_Load(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand sql = new SqlCommand("SELECT * FROM Пользователи", connect);
            SqlDataReader reader = sql.ExecuteReader();

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
                SqlCommand sql = new SqlCommand("INSERT Сотрудники VALUES(@fam, @name, @otch, @dol, @add, @id)", connect);
                sql.Parameters.AddWithValue("@fam", textBox1.Text);
                sql.Parameters.AddWithValue("@name", textBox2.Text);
                sql.Parameters.AddWithValue("@otch", textBox3.Text);    
                sql.Parameters.AddWithValue("@dol", comboBox4.Text);
                sql.Parameters.AddWithValue("@add", textBox5.Text);
                sql.Parameters.AddWithValue("@id", comboBox6.Text);
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
    }
}
