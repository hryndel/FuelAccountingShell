using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.FuelStation;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditFuelStation : MaterialForm
    {
        private FuelStationResponse FuelStation = new FuelStationResponse();
        private bool IsEdit = false;
        private DialogResult Dialog = DialogResult.None;

        public FormAddEditFuelStation()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditFuelStation(FuelStationResponse fuelStation) : this()
        {
            IsEdit = true;
            buttonAccept.Text = "Изменить";

            FuelStation.Id = fuelStation.Id;
            textBoxName.Text = fuelStation.Name;
            multiTextBoxAddress.Text = fuelStation.Address;
            multiTextBoxDescription.Text = fuelStation.Description;
        }

        private void buttonAccept_Click(object sender, System.EventArgs e)
        {
            FuelStation.Name = textBoxName.Text.Trim();
            FuelStation.Address = multiTextBoxAddress.Text.Trim();
            FuelStation.Description = multiTextBoxDescription.Text.Trim();
            if (!IsEdit)
            {
                Dialog = CommonClient.CreateData(FuelStation, "FuelStation/");
            }
            else
            {
                Dialog = CommonClient.UpdateData(FuelStation, "FuelStation/");
            }
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
