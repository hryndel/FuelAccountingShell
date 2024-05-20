using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlDriver : UserControl
    {
        public UserControlDriver()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditDriver form = new FormAddEditDriver();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditDriver form = new FormAddEditDriver("test");
            form.ShowDialog();
        }
    }
}
