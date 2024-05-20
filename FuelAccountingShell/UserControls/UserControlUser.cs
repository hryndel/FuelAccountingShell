using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlUser : UserControl
    {
        public UserControlUser()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditUser form = new FormAddEditUser();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditUser form = new FormAddEditUser("test");
            form.ShowDialog();
        }
    }
}
