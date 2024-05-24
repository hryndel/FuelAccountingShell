using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Supplier;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlSupplier : UserControl
    {
        public UserControlSupplier()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewSuppliers);
        }

        private async void UserControlSupplier_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<SupplierResponse>("Supplier/");
            dataGridViewSuppliers.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewSuppliers.Rows.Count} из {items.Count}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditSupplier form = new FormAddEditSupplier();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditSupplier form = new FormAddEditSupplier("test");
            form.ShowDialog();
        }
    }
}
