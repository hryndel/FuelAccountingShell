using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditTrailer : MaterialForm
    {
        public FormAddEditTrailer()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditTrailer(string test) : this()
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

        private void textBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
