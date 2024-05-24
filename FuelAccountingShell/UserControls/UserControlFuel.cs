using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Fuel;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuel : UserControl
    {
        public UserControlFuel()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewFuels);
        }

        private async void UserControlFuel_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<FuelResponse>("Fuel/");
            dataGridViewFuels.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewFuels.Rows.Count} из {items.Count}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuel form = new FormAddEditFuel();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuel form = new FormAddEditFuel("test");
            form.ShowDialog();
        }
    }
}
