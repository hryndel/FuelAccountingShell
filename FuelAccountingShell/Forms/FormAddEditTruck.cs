using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Truck;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditTruck : MaterialForm
    {
        private TruckRequest Truck = new TruckRequest();
        private bool IsEdit = false;
        private DialogResult Dialog = DialogResult.None;

        public FormAddEditTruck()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditTruck(TruckResponse truck) : this()
        {
            IsEdit = true;
            buttonAccept.Text = "Изменить";

            Truck.Id = truck.Id;
            textBoxName.Text = truck.Name;
            maskedTextBoxNumber.Text = truck.Number;
            textBoxVin.Text = truck.Vin;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Truck.Name = textBoxName.Text.Trim();
            Truck.Number = maskedTextBoxNumber.Text.Trim();
            Truck.Vin = textBoxVin.Text.Trim();
            if (!IsEdit)
            {
                Dialog = CommonClient.CreateData(Truck, "Truck/");
            }
            else
            {
                Dialog = CommonClient.UpdateData(Truck, "Truck/");
            }
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
