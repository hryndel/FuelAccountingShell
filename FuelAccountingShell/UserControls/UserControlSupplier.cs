using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlSupplier : UserControl
    {
        public UserControlSupplier()
        {
            InitializeComponent();
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
