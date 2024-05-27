using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Enums;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
            if (JSonWebToken.UserTypes != UserTypes.Administrator) tabPageUser.Dispose();
        }

        private void materialTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Text = tabControl.SelectedTab.Tag.ToString();
            if (CloseForms.SystemClosing) return;

            switch (tabControl.SelectedIndex)
            {
                case 0: userControlFuelAccountingItem.UserControlFuelAccountingItem_Load(sender, e); break;
                case 1: userControlFuel.UserControlFuel_Load(sender, e); break;
                case 2: userControlSupplier.UserControlSupplier_Load(sender, e); break;
                case 3: userControlFuelStation.UserControlFuelStation_Load(sender, e); break;
                case 4: userControlDriver.UserControlDriver_Load(sender, e); break;
                case 5: userControlTrailer.UserControlTrailer_Load(sender, e); break;
                case 6: userControlTruck.UserControlTruck_Load(sender, e); break;
                case 7: userControlUser.UserControlUser_Load(sender, e); break;

            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseForms.SystemClosing)
            {
                var dialogResult = MaterialMessageBox.Show("Вы действительно хотите выйти из учетной записи?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question, false);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
