using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.Fuel;
using FuelAccountingShell.Models.Supplier;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuel : UserControl
    {
        private List<FuelResponse> Fuels;

        public UserControlFuel()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewFuels);
            if (!this.DesignMode)
            {
                FillListBox();
                materialListBoxTypes.SelectedIndex = 0;
            }
        }

        public void UserControlFuel_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Fuels = CommonClient.GetData<FuelResponse>("Fuel/");
            if (CloseForms.SystemClosing) return;
            dataGridViewFuels.DataSource = Fuels;
            labelStatus.Text = $"Количество записей: {dataGridViewFuels.Rows.Count} из {Fuels.Count}";

            buttonEdit.Enabled = buttonDelete.Enabled = (CheckCountRows.CheckCount(dataGridViewFuels.Rows.Count) && JSonWebToken.UserTypes != UserTypes.Employee);
            buttonAdd.Enabled = JSonWebToken.UserTypes != UserTypes.Employee;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuel form = new FormAddEditFuel();
            form.ShowDialog();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuel form = new FormAddEditFuel((FuelResponse)dataGridViewFuels.CurrentRow.DataBoundItem);
            form.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommonClient.DeleteData(((FuelResponse)dataGridViewFuels.CurrentRow.DataBoundItem).Id, "Fuel/");
            LoadData();
        }

        private void SearchAndFiltr()
        {
            if (materialListBoxTypes.SelectedItem.Tag is FuelTypes enm)
            {
                dataGridViewFuels.DataSource = Fuels.Where(x => x.FuelType.ToString() == enm.ToString() && x.Supplier.Name.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            }
            else
            {
                dataGridViewFuels.DataSource = Fuels.Where(x => x.Supplier.Name.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            }
            labelStatus.Text = $"Количество записей: {dataGridViewFuels.Rows.Count} из {Fuels.Count}";
        }

        private void materialListBoxFiltr_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            SearchAndFiltr();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAndFiltr();
        }

        private void dataGridViewFuels_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewFuels.Columns[e.ColumnIndex].DataPropertyName == "FuelType")
            {
                var type = (FuelTypes)e.Value;
                e.Value = type.EnumRead();
            }

            if (dataGridViewFuels.Columns[e.ColumnIndex].DataPropertyName == "Supplier")
            {
                var value = (SupplierResponse)e.Value;
                e.Value = $"{value.Name} | {value.Inn}";
            }

            if (dataGridViewFuels.Columns[e.ColumnIndex].DataPropertyName == "Count")
            {
                e.Value = $"{e.Value} л.";
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
        }
    }
}
