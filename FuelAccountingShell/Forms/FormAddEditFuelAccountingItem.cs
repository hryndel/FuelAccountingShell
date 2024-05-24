using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;
using System;
using System.Drawing;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditFuelAccountingItem : MaterialForm
    {
        public FormAddEditFuelAccountingItem()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.MinDate = dateTimePickerStartDate.Value;

            dateTimePickerStartDate.BackColor = Color.FromArgb(95, 95, 95);
        }

        public FormAddEditFuelAccountingItem(string test) : this()
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
