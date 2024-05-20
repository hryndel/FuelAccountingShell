using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlTruck : UserControl
    {
        public UserControlTruck()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditTruck form = new FormAddEditTruck();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditTruck form = new FormAddEditTruck("test");
            form.ShowDialog();
        }
    }
}
