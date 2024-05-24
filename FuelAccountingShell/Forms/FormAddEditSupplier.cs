using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditSupplier : MaterialForm
    {
        public FormAddEditSupplier()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditSupplier(string test) : this()
        {
            buttonAccept.Text = "Изменить";
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Close();
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
