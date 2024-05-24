using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Truck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlTruck : UserControl
    {
        private List<TruckResponse> Trucks;
        public UserControlTruck()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewTrucks);
        }

        private async void UserControlTruck_Load(object sender, EventArgs e)
        {
            materialListBoxSort.SelectedIndex = 0;

            Trucks = await CommonClient.GetData<TruckResponse>("Truck/");
            dataGridViewTrucks.DataSource = Trucks;
            labelStatus.Text = $"Количество записей: {dataGridViewTrucks.Rows.Count} из {Trucks.Count}";
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

        public void SearchAndSort()
        {
            var items = Trucks.Where(x => x.Name.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            switch (materialListBoxSort.SelectedIndex)
            {
                case 0:
                    dataGridViewTrucks.DataSource = items;
                    break;
                case 1: 
                    items.Sort((a, b) => a.Name.CompareTo(b.Name));
                    break;
                case 2:
                    items.Sort((a, b) => b.Name.CompareTo(a.Name));
                    break;
            }
            dataGridViewTrucks.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewTrucks.Rows.Count} из {Trucks.Count}";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAndSort();
        }

        private void materialListBoxSort_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            SearchAndSort();
        }
    }
}
