using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;

namespace FuelAccountingShell.Forms
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        private void materialTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Text = tabControl.SelectedTab.Tag.ToString();
        }
    }
}
