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
using Microsoft.Reporting.WinForms;

namespace programm
{
    public partial class PriceListForm : MetroFramework.Forms.MetroForm
    {
        public PriceListForm()
        {
            InitializeComponent();
            this.Услуги1TableAdapter.Fill(this.Repair_serviceDataSet.Услуги1);
            this.Услуги1BindingSource.DataMember = "Услуги1";
            this.Услуги1BindingSource.DataSource = this.Repair_serviceDataSet;
        }

        private void PriceListForm_Load(object sender, EventArgs e)
        {
            //проверка включена ли темная тема для правильного отображения переключателя
            if (this.StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                mSwitch.Checked = false;

            metroTabControl1.SelectedTab = metroTabControl1.TabPages[0];

            this.Услуги3TableAdapter.Fill(this.Repair_serviceDataSet.Услуги3);
            this.Услуги2TableAdapter.Fill(this.Repair_serviceDataSet.Услуги2);
            this.Услуги1TableAdapter.Fill(this.Repair_serviceDataSet.Услуги1);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
            this.reportViewer6.RefreshReport();
        }

        private void mSwitch_CheckedChanged(object sender, EventArgs e)
        {
            //смена темы
            if (mSwitch.Checked) 
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            else 
                StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
        }
    }
}
