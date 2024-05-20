using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuelAccountingItem : UserControl
    {
        public UserControlFuelAccountingItem()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuelAccountingItem form = new FormAddEditFuelAccountingItem();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuelAccountingItem form = new FormAddEditFuelAccountingItem("test");
            form.ShowDialog();
        }
    }
}
