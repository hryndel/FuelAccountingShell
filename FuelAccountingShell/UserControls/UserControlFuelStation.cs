using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.FuelStation;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuelStation : UserControl
    {
        public UserControlFuelStation()
        {
            InitializeComponent(); 
            DataGridVeiwStyle.Stylization(dataGridViewFuelStations);
        }

        private async void UserControlFuelStation_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<FuelStationResponse>("FuelStation/");
            dataGridViewFuelStations.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewFuelStations.Rows.Count} из {items.Count}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuelStation form = new FormAddEditFuelStation();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuelStation form = new FormAddEditFuelStation("test");
            form.ShowDialog();
        }
    }
}
