using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Driver;
using FuelAccountingShell.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlDriver : UserControl
    {
        private List<DriverResponse> Drivers;

        public UserControlDriver()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewDrivers);
            if (!this.DesignMode)
            {
                materialListBoxSort.SelectedIndex = 0;
            }
        }

        public void UserControlDriver_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Drivers = CommonClient.GetData<DriverResponse>("Driver/");
            if (CloseForms.SystemClosing) return;
            dataGridViewDrivers.DataSource = Drivers;
            labelStatus.Text = $"Количество записей: {dataGridViewDrivers.Rows.Count} из {Drivers.Count}";

            buttonEdit.Enabled = buttonDelete.Enabled = (CheckCountRows.CheckCount(dataGridViewDrivers.Rows.Count) && JSonWebToken.UserTypes != UserTypes.Employee);
            buttonAdd.Enabled = JSonWebToken.UserTypes != UserTypes.Employee;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditDriver form = new FormAddEditDriver();
            form.ShowDialog();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditDriver form = new FormAddEditDriver((DriverResponse)dataGridViewDrivers.CurrentRow.DataBoundItem);
            form.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommonClient.DeleteData(((DriverResponse)dataGridViewDrivers.CurrentRow.DataBoundItem).Id, "Driver/");
            LoadData();
        }

        private void SearchAndSort()
        {
            var items = Drivers.Where(x => x.DriversLicense.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            switch (materialListBoxSort.SelectedIndex)
            {
                case 0:
                    dataGridViewDrivers.DataSource = items;
                    break;
                case 1:
                    items.Sort((a, b) => a.LastName.CompareTo(b.LastName));
                    break;
                case 2:
                    items.Sort((a, b) => b.LastName.CompareTo(a.LastName));
                    break;
            }
            dataGridViewDrivers.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewDrivers.Rows.Count} из {Drivers.Count}";
        }

        private void materialListBoxSort_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            SearchAndSort();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAndSort();
        }
    }
}
