using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Trailer;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditTrailer : MaterialForm
    {
        private TrailerRequest Trailer = new TrailerRequest();
        private bool IsEdit = false;
        private DialogResult Dialog = DialogResult.None;

        public FormAddEditTrailer()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditTrailer(TrailerResponse trailer) : this()
        {
            IsEdit = true;
            buttonAccept.Text = "Изменить";

            Trailer.Id = trailer.Id;
            textBoxName.Text = trailer.Name;
            maskedTextBoxNumber.Text = trailer.Number;
            textBoxCapacity.Text = trailer.Capacity.ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Trailer.Name = textBoxName.Text.Trim();
            Trailer.Number = maskedTextBoxNumber.Text.Trim();
            Trailer.Capacity = double.TryParse(textBoxCapacity.Text, out var capacity) ? capacity : 0.0;
            if (!IsEdit)
            {
                Dialog = CommonClient.CreateData(Trailer, "Trailer/");
            }
            else
            {
                Dialog = CommonClient.UpdateData(Trailer, "Trailer/");
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

        private void textBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
