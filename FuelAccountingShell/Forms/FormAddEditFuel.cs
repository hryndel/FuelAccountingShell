using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditFuel : MaterialForm
    {
        public FormAddEditFuel()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditFuel(string test) : this()
        {
            buttonAccept.Text = "Изменить";
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
