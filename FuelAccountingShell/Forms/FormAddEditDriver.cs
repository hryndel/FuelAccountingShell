using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Driver;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditDriver : MaterialForm
    {
        private DriverResponse Driver = new DriverResponse();
        private bool IsEdit = false;
        private DialogResult Dialog = DialogResult.None;

        public FormAddEditDriver()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        public FormAddEditDriver(DriverResponse driver) : this()
        {
            IsEdit = true;
            buttonAccept.Text = "Изменить";

            Driver.Id = driver.Id;
            textBoxFirstName.Text = driver.FirstName;
            textBoxSecondName.Text = driver.LastName;
            textBoxPatronymic.Text = driver.Patronymic;
            masketTextBoxNumber.Text = driver.Phone;
            maskedTextBoxDriversLicense.Text = driver.DriversLicense;
        }

        private void buttonAccept_Click(object sender, System.EventArgs e)
        {
            Driver.FirstName = textBoxFirstName.Text.Trim();
            Driver.LastName = textBoxSecondName.Text.Trim();
            Driver.Patronymic = textBoxPatronymic.Text.Trim();
            Driver.Phone = masketTextBoxNumber.Text.Trim();
            Driver.DriversLicense = maskedTextBoxDriversLicense.Text.Trim();
            if (!IsEdit)
            {
                Dialog = CommonClient.CreateData(Driver, "Driver/");
            }
            else
            {
                Dialog = CommonClient.UpdateData(Driver, "Driver/");
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
