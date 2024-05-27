using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.FuelStation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuelStation : UserControl
    {
        private List<FuelStationResponse> FuelStations;
        public UserControlFuelStation()
        {
            InitializeComponent(); 
            DataGridVeiwStyle.Stylization(dataGridViewFuelStations);
            if (!this.DesignMode)
            {
                materialListBoxSort.SelectedIndex = 0;
            }
        }

        public void UserControlFuelStation_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            FuelStations = CommonClient.GetData<FuelStationResponse>("FuelStation/");
            if (CloseForms.SystemClosing) return;
            dataGridViewFuelStations.DataSource = FuelStations;
            labelStatus.Text = $"Количество записей: {dataGridViewFuelStations.Rows.Count} из {FuelStations.Count}";

            buttonEdit.Enabled = buttonDelete.Enabled = (CheckCountRows.CheckCount(dataGridViewFuelStations.Rows.Count) && JSonWebToken.UserTypes != UserTypes.Employee);
            buttonAdd.Enabled = JSonWebToken.UserTypes != UserTypes.Employee;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuelStation form = new FormAddEditFuelStation();
            form.ShowDialog();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuelStation form = new FormAddEditFuelStation((FuelStationResponse)dataGridViewFuelStations.CurrentRow.DataBoundItem);
            form.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommonClient.DeleteData(((FuelStationResponse)dataGridViewFuelStations.CurrentRow.DataBoundItem).Id, "FuelStation/");
            LoadData();
        }

        private void SearchAndSort()
        {
            var items = FuelStations.Where(x => x.Name.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            switch (materialListBoxSort.SelectedIndex)
            {
                case 0:
                    dataGridViewFuelStations.DataSource = items;
                    break;
                case 1:
                    items.Sort((a, b) => b.Name.CompareTo(a.Name));
                    break;
                case 2:
                    items.Sort((a, b) => a.Name.CompareTo(b.Name));
                    break;
            }
            dataGridViewFuelStations.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewFuelStations.Rows.Count} из {FuelStations.Count}";
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
