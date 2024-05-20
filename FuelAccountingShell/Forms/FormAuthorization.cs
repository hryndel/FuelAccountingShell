using FuelAccountingShell.Infrastructure;
using MaterialSkin.Controls;

namespace FuelAccountingShell.Forms
{
    public partial class FormAuthorization : MaterialForm
    {
        public FormAuthorization()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        private void buttonEnter_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            FormMain form = new FormMain();
            form.ShowDialog();
            this.Show();
        }
    }
}
