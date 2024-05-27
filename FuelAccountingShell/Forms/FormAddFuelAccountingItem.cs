using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Driver;
using FuelAccountingShell.Models.Fuel;
using FuelAccountingShell.Models.FuelAccountingItem;
using FuelAccountingShell.Models.FuelStation;
using FuelAccountingShell.Models.Trailer;
using FuelAccountingShell.Models.Truck;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddFuelAccountingItem : MaterialForm
    {
        private FuelAccountingItemRequest FuelAccountingItem = new FuelAccountingItemRequest();
        private DialogResult Dialog = DialogResult.None;

        public FormAddFuelAccountingItem()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
            FillComboBox();
            dateTimePickerStartDate.MinDate = DateTime.Now;
            dateTimePickerEndDate.MinDate = dateTimePickerStartDate.Value;
            buttonAccept.Enabled = CheckButton();
        }

        private bool CheckButton()
        {
            if (comboBoxDriver.Items.Count <= 0)return false;
            if (comboBoxTruck.Items.Count <= 0) return false;
            if (comboBoxTrailer.Items.Count <= 0) return false;
            if (comboBoxFuel.Items.Count <= 0) return false;
            if (comboBoxFuelStation.Items.Count <= 0) return false;
            return true;
        }

        private void FillComboBox()
        {
            comboBoxDriver.DataSource = CommonClient.GetData<DriverResponse>("Driver/free");
            comboBoxDriver.DisplayMember = "DriversLicense";
            comboBoxDriver.ValueMember = "Id";

            comboBoxTruck.DataSource = CommonClient.GetData<TruckResponse>("Truck/free");
            comboBoxTruck.DisplayMember = "Name";
            comboBoxTruck.ValueMember = "Id";

            comboBoxTrailer.DataSource = CommonClient.GetData<TrailerResponse>("Trailer/free");
            comboBoxTrailer.DisplayMember = "Name";
            comboBoxTrailer.ValueMember = "Id";

            comboBoxFuel.DataSource = CommonClient.GetData<FuelResponse>("Fuel/");
            comboBoxFuel.DisplayMember = "FuelType";
            comboBoxFuel.ValueMember = "Id";

            comboBoxFuelStation.DataSource = CommonClient.GetData<FuelStationResponse>("FuelStation/");
            comboBoxFuelStation.DisplayMember = "Name";
            comboBoxFuelStation.ValueMember = "Id";
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            FuelAccountingItem.DriverId = (Guid)comboBoxDriver.SelectedValue;
            FuelAccountingItem.TruckId = (Guid)comboBoxTruck.SelectedValue;
            FuelAccountingItem.TrailerId = (Guid)comboBoxTrailer.SelectedValue;
            FuelAccountingItem.FuelId = (Guid)comboBoxFuel.SelectedValue;
            FuelAccountingItem.Count = double.TryParse(textBoxCount.Text, out var capacity) ? capacity : 0.0;
            FuelAccountingItem.FuelStationId = (Guid)comboBoxFuelStation.SelectedValue;
            FuelAccountingItem.StartDate = dateTimePickerStartDate.Value.ToUniversalTime();
            FuelAccountingItem.EndDate = dateTimePickerEndDate.Value.ToUniversalTime();

            Dialog = CommonClient.CreateData(FuelAccountingItem, "FuelAccountingItem/");
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxDriver_Format(object sender, ListControlConvertEventArgs e)
        {
            var driver = (DriverResponse)e.ListItem;
            e.Value = $"{driver.DriversLicense} | {driver.FirstName} {driver.LastName} {driver.Patronymic}";
        }

        private void comboBoxTruck_Format(object sender, ListControlConvertEventArgs e)
        {
            var truck = (TruckResponse)e.ListItem;
            e.Value = $"{truck.Number} | {truck.Name}";
        }

        private void comboBoxTrailer_Format(object sender, ListControlConvertEventArgs e)
        {
            var trailer = (TrailerResponse)e.ListItem;
            e.Value = $"{trailer.Number} | {trailer.Capacity} | {trailer.Name}";
        }

        private void comboBoxFuel_Format(object sender, ListControlConvertEventArgs e)
        {
            var fuel = (FuelResponse)e.ListItem;
            e.Value = $"{fuel.FuelType} | {fuel.Supplier.Name} | {fuel.Count}";
        }

        private void comboBoxFuelStation_Format(object sender, ListControlConvertEventArgs e)
        {
            var fuelStation = (FuelStationResponse)e.ListItem;
            e.Value = $"{fuelStation.Name} | {fuelStation.Address}";
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEndDate.MinDate = dateTimePickerStartDate.Value;
        }
    }
}
