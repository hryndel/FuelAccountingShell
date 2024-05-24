using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Driver;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlDriver : UserControl
    {
        public UserControlDriver()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewDrivers);
        }

        private async void UserControlDriver_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<DriverResponse>("Driver/");
            dataGridViewDrivers.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewDrivers.Rows.Count} из {items.Count}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditDriver form = new FormAddEditDriver();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditDriver form = new FormAddEditDriver("test");
            form.ShowDialog();
        }
    }
}
