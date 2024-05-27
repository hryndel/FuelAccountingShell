using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlSupplier : UserControl
    {
        private List<SupplierResponse> Suppliers;

        public UserControlSupplier()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewSuppliers);
            if (!this.DesignMode)
            {
                materialListBoxSort.SelectedIndex = 0;
            }
        }

        public void UserControlSupplier_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Suppliers = CommonClient.GetData<SupplierResponse>("Supplier/");
            if (CloseForms.SystemClosing) return;
            dataGridViewSuppliers.DataSource = Suppliers;
            labelStatus.Text = $"Количество записей: {dataGridViewSuppliers.Rows.Count} из {Suppliers.Count}";

            buttonEdit.Enabled = buttonDelete.Enabled = (CheckCountRows.CheckCount(dataGridViewSuppliers.Rows.Count) && JSonWebToken.UserTypes != UserTypes.Employee);
            buttonAdd.Enabled = JSonWebToken.UserTypes != UserTypes.Employee;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditSupplier form = new FormAddEditSupplier();
            form.ShowDialog();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditSupplier form = new FormAddEditSupplier((SupplierResponse)dataGridViewSuppliers.CurrentRow.DataBoundItem);
            form.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommonClient.DeleteData(((SupplierResponse)dataGridViewSuppliers.CurrentRow.DataBoundItem).Id, "Supplier/");
            LoadData();
        }

        private void SearchAndSort()
        {
            var items = Suppliers.Where(x => x.Name.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            switch (materialListBoxSort.SelectedIndex)
            {
                case 0:
                    dataGridViewSuppliers.DataSource = items;
                    break;
                case 1:
                    items.Sort((a, b) => b.Name.CompareTo(a.Name));
                    break;
                case 2:
                    items.Sort((a, b) => a.Name.CompareTo(b.Name));
                    break;
            }
            dataGridViewSuppliers.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewSuppliers.Rows.Count} из {Suppliers.Count}";
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
