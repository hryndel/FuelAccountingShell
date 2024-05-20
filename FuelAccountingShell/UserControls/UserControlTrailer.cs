using FuelAccountingShell.Forms;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlTrailer : UserControl
    {
        public UserControlTrailer()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditTrailer form = new FormAddEditTrailer();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditTrailer form = new FormAddEditTrailer("test");
            form.ShowDialog();
        }
    }
}
