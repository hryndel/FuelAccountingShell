using FuelAccountingShell.Infrastructure;
using MaterialSkin.Controls;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditDriver : MaterialForm
    {
        public FormAddEditDriver()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditDriver(string test) : this()
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
