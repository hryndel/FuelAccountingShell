using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Supplier;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditSupplier : MaterialForm
    {
        private SupplierRequest Supplier = new SupplierRequest();
        private bool IsEdit = false;
        private DialogResult Dialog = DialogResult.None;

        public FormAddEditSupplier()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditSupplier(SupplierResponse supplier) : this()
        {
            IsEdit = true;
            buttonAccept.Text = "Изменить";

            Supplier.Id = supplier.Id;
            textBoxName.Text = supplier.Name;
            textBoxInn.Text = supplier.Inn;
            masketTextBoxNumber.Text = supplier.Phone;
            multiTextBoxDescription.Text = supplier.Description;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Supplier.Name = textBoxName.Text.Trim();
            Supplier.Inn = textBoxInn.Text.Trim();
            Supplier.Phone = masketTextBoxNumber.Text.Trim();
            Supplier.Description = multiTextBoxDescription.Text.Trim();
            if (!IsEdit)
            {
                Dialog = CommonClient.CreateData(Supplier, "Supplier/");
            }
            else
            {
                Dialog = CommonClient.UpdateData(Supplier, "Supplier/");
            }
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxInn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
