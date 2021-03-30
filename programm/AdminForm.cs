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
    public partial class AdminForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Repair_service;Integrated Security=True");
        SqlDataAdapter adapter;
        string table_name;
        DataSet ds = new DataSet();

        public AdminForm()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
            metroTabControl1.SelectedTab = metroTabControl1.TabPages[0];
            btnRefresh_Click(this, EventArgs.Empty);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            this.StyleManager.Clone(log);
            log.Show();
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (mSwitch.Checked)
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void metroTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            btnRefresh_Click(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись? Это действие нельзя будет отменить", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string id = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
                    string ColumnName = "[" + this.metroGrid1.Columns[0].Name + "]";
                    Convert.ToInt32(id);
                    connect.Open();
                    SqlCommand sql = new SqlCommand($"DELETE FROM {table_name} WHERE {ColumnName} = '{id}'", connect);
                    sql.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Запись была успешно удалена из базы данных", "Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh_Click(this, EventArgs.Empty);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    connect.Open();
                    SqlCommand sql = new SqlCommand(@"SELECT * FROM Пользователи", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Пользователи";
                    connect.Close();
                    //скрытие строки с данными администратора
                    metroGrid1.Rows[1].Visible = false;
                    break;
                case 1:
                    connect.Open();
                    sql = new SqlCommand(@"SELECT * FROM Клиенты", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds, "Клиенты");
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Клиенты";
                    connect.Close();
                    break;
                case 2:
                    connect.Open();
                    sql = new SqlCommand(@"SELECT * FROM Заказы", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds, "Заказы");
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Заказы";
                    connect.Close();
                    break;
                case 3:
                    connect.Open();
                    sql = new SqlCommand(@"SELECT * FROM Сотрудники", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Сотрудники";
                    connect.Close();
                    break;
                case 4:
                    connect.Open();
                    sql = new SqlCommand(@"SELECT * FROM Услуги", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Услуги";
                    connect.Close();
                    break;
                case 5:
                    connect.Open();
                    sql = new SqlCommand(@"SELECT * FROM Склад", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Склад";
                    connect.Close();
                    break;
                case 6:
                    connect.Open();
                    sql = new SqlCommand(@"SELECT * FROM [Оказанные услуги]", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Оказанные услуги";
                    connect.Close();
                    break;
                case 7:
                    connect.Open();
                    sql = new SqlCommand(@"SELECT * FROM [Использованные детали]", connect);
                    adapter = new SqlDataAdapter(sql);
                    ds = new DataSet();
                    adapter.Fill(ds);
                    metroGrid1.DataSource = ds.Tables[0];
                    table_name = "Использованные детали";
                    connect.Close();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    PolzForm Pol = new PolzForm();
                    this.StyleManager.Clone(Pol);
                    Pol.ShowDialog();
                    break;
                case 1:
                    ClientForm Cli = new ClientForm();
                    this.StyleManager.Clone(Cli);
                    Cli.ShowDialog();
                    break;
                case 2:
                    ZakazForm Zak = new ZakazForm();
                    this.StyleManager.Clone(Zak);
                    Zak.ShowDialog();
                    break;
                case 3:
                    SotrForm Sot = new SotrForm();
                    this.StyleManager.Clone(Sot);
                    Sot.ShowDialog();
                    break;
                case 4:
                    UslugForm Usl = new UslugForm();
                    this.StyleManager.Clone(Usl);
                    Usl.ShowDialog();
                    break;
                case 5:
                    SkladForm Skd = new SkladForm();
                    this.StyleManager.Clone(Skd);
                    Skd.ShowDialog();
                    break;
                case 6:
                    OkUslForm Ou = new OkUslForm();
                    this.StyleManager.Clone(Ou);
                    Ou.ShowDialog();
                    break;
                case 7:
                    IspDetForm IspD = new IspDetForm();
                    this.StyleManager.Clone(IspD);
                    IspD.ShowDialog();
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    UpPolzForm UpPol = new UpPolzForm(id);
                    this.StyleManager.Clone(UpPol);
                    UpPol.ShowDialog();
                    break;
                case 1:
                    UpClientForm UpCli = new UpClientForm(id);
                    this.StyleManager.Clone(UpCli);
                    UpCli.ShowDialog();
                    break;
                case 2:
                    UpZakazForm UpZak = new UpZakazForm(id);
                    this.StyleManager.Clone(UpZak);
                    UpZak.ShowDialog();
                    break;
                case 3:
                    UpSotrForm UpSot = new UpSotrForm(id);
                    this.StyleManager.Clone(UpSot);
                    UpSot.ShowDialog();
                    break;
                case 4:
                    UpUslugForm UpUsl = new UpUslugForm(id);
                    this.StyleManager.Clone(UpUsl);
                    UpUsl.ShowDialog();
                    break;
                case 5:
                    UpSkladForm UpSkd = new UpSkladForm(id);
                    this.StyleManager.Clone(UpSkd);
                    UpSkd.ShowDialog();
                    break;
                case 6:
                    UpOkUslForm UpOu = new UpOkUslForm(id);
                    this.StyleManager.Clone(UpOu);
                    UpOu.ShowDialog();
                    break;
                case 7:
                    UpIspDetForm UpIspD = new UpIspDetForm(id);
                    this.StyleManager.Clone(UpIspD);
                    UpIspD.ShowDialog();
                    break;
            }
        }
    }
}