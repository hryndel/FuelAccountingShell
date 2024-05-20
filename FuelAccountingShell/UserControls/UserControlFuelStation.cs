using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuelStation : UserControl
    {
        public UserControlFuelStation()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuelStation form = new FormAddEditFuelStation();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuelStation form = new FormAddEditFuelStation("test");
            form.ShowDialog();
        }
    }
}
