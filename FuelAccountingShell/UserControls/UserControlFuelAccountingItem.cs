using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Driver;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.Fuel;
using FuelAccountingShell.Models.FuelAccountingItem;
using FuelAccountingShell.Models.FuelStation;
using FuelAccountingShell.Models.Trailer;
using FuelAccountingShell.Models.Truck;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuelAccountingItem : UserControl
    {
        private List<FuelAccountingItemResponse> FuelAccountingItems;

        public UserControlFuelAccountingItem()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewFuelAccountingItems);
            if (!this.DesignMode)
            {
                FillListBox();
            }
        }

        public void UserControlFuelAccountingItem_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            FuelAccountingItems = CommonClient.GetData<FuelAccountingItemResponse>("FuelAccountingItem/");
            if (CloseForms.SystemClosing) return;
            dataGridViewFuelAccountingItems.DataSource = FuelAccountingItems;
            labelStatus.Text = $"Количество записей: {dataGridViewFuelAccountingItems.Rows.Count} из {FuelAccountingItems.Count}";

            buttonDelete.Enabled = buttonPdf.Enabled = CheckCountRows.CheckCount(dataGridViewFuelAccountingItems.Rows.Count);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddFuelAccountingItem form = new FormAddFuelAccountingItem();
            form.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommonClient.DeleteData(((FuelAccountingItemResponse)dataGridViewFuelAccountingItems.CurrentRow.DataBoundItem).Id, "FuelAccountingItem/");
            LoadData();
        }

        private void materialButtonPdf_Click(object sender, EventArgs e)
        {
            var Id = ((FuelAccountingItemResponse)dataGridViewFuelAccountingItems.Rows[dataGridViewFuelAccountingItems.SelectedRows[0].Index].DataBoundItem).Id;
            var data = CommonClient.GetDocument(Id);
            try
            {
                saveFileDialogSave.FileName = $"Накладная-№{Id}";
                if (saveFileDialogSave.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialogSave.FileName, data);
                    MaterialMessageBox.Show("Накладная успешно сохранена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information, false);
                }
            }
            catch
            {
                MaterialMessageBox.Show("Не удалось сохранить файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false);
            }
        }

        private void SearchAndFiltrAndSort()
        {
            var items = FuelAccountingItems.Where(x => x.FuelStation.Name.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            if (materialListBoxTypes.SelectedItem.Tag is FuelTypes enm)
            {
                items = items.Where(x => x.Fuel.FuelType.ToString() == enm.ToString()).ToList();
            }

            switch (materialListBoxSort.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    items.Sort((a, b) => a.EndDate.CompareTo(b.EndDate));
                    break;
                case 2:
                    items.Sort((a, b) => b.EndDate.CompareTo(a.EndDate));
                    break;
            }
            dataGridViewFuelAccountingItems.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewFuelAccountingItems.Rows.Count} из {FuelAccountingItems.Count}";
        }

        private void materialListBoxSort_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            SearchAndFiltrAndSort();
        }

        private void materialListBoxTypes_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            SearchAndFiltrAndSort();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAndFiltrAndSort();
        }

        private void dataGridViewFuelAccountingItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewFuelAccountingItems.Columns[e.ColumnIndex].DataPropertyName == "Driver")
            {
                var driver = (DriverResponse)e.Value;
                e.Value = $"{driver.FirstName} {driver.LastName} {driver.Patronymic} | {driver.DriversLicense}";
            }

            if (dataGridViewFuelAccountingItems.Columns[e.ColumnIndex].DataPropertyName == "Truck")
            {
                var truck = (TruckResponse)e.Value;
                e.Value = $"{truck.Name} | {truck.Number}";
            }

            if (dataGridViewFuelAccountingItems.Columns[e.ColumnIndex].DataPropertyName == "Trailer")
            {
                var trailer = (TrailerResponse)e.Value;
                e.Value = $"{trailer.Name} | {trailer.Number}";
            }

            if (dataGridViewFuelAccountingItems.Columns[e.ColumnIndex].DataPropertyName == "Fuel")
            {
                var fuel = (FuelResponse)e.Value;
                e.Value = $"{fuel.FuelType} | {fuel.Supplier.Name}";
            }

            if (dataGridViewFuelAccountingItems.Columns[e.ColumnIndex].DataPropertyName == "FuelStation")
            {
                var fuelStation = (FuelStationResponse)e.Value;
                e.Value = $"{fuelStation.Name} | {fuelStation.Address}";
            }

            if (dataGridViewFuelAccountingItems.Columns[e.ColumnIndex].DataPropertyName == "StartDate")
            {
                var dateTime = (DateTimeOffset)e.Value;
                e.Value = dateTime.ToLocalTime();
            }

            if (dataGridViewFuelAccountingItems.Columns[e.ColumnIndex].DataPropertyName == "EndDate")
            {
                var dateTime = (DateTimeOffset)e.Value;
                e.Value = dateTime.ToLocalTime();
            }
        }

        private void FillListBox()
        {
            materialListBoxTypes.Items.Clear();
            materialListBoxTypes.Items.Add(new MaterialListBoxItem("По умолчанию"));
            foreach (FuelTypes dir in Enum.GetValues(typeof(FuelTypes)))
            {
                var materialSkikItem = new MaterialListBoxItem();
                materialSkikItem.Text = dir.EnumRead();
                materialSkikItem.Tag = dir;
                materialListBoxTypes.Items.Add(materialSkikItem);
            }
            materialListBoxTypes.SelectedIndex = 0;
            materialListBoxSort.SelectedIndex = 0;
        }
    }
}
