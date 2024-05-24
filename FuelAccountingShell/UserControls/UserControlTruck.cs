using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Truck;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlTruck : UserControl
    {
        public UserControlTruck()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewTrucks);
        }

        private async void UserControlTruck_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<TruckResponse>("Truck/");
            dataGridViewTrucks.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewTrucks.Rows.Count} из {items.Count}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditTruck form = new FormAddEditTruck();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditTruck form = new FormAddEditTruck("test");
            form.ShowDialog();
        }
    }
}
