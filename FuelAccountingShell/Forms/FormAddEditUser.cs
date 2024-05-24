using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditUser : MaterialForm
    {
        public FormAddEditUser()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditUser(string test) : this()
        {
            buttonAccept.Text = "Изменить";
        }

        private void buttonAccept_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
