using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;
using System;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditTruck : MaterialForm
    {
        public FormAddEditTruck()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditTruck(string test) : this()
        {
            buttonAccept.Text = "Изменить";
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
