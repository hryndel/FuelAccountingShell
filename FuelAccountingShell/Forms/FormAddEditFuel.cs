using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Infrastructure.WorkWithEnums;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.Fuel;
using FuelAccountingShell.Models.Supplier;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditFuel : MaterialForm
    {
        private FuelRequest Fuel = new FuelRequest();
        private bool IsEdit = false;
        private DialogResult Dialog = DialogResult.None;

        public FormAddEditFuel()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
            FillComboBox();
            buttonAccept.Enabled = CheckButton();
        }

        public FormAddEditFuel(FuelResponse fuel) : this()
        {
            IsEdit = true;
            buttonAccept.Text = "Изменить";

            Fuel.Id = fuel.Id;
            comboBoxType.SelectedItem = comboBoxType.Items.Cast<EnumConverter>().FirstOrDefault(x => (FuelTypes)x.Type == fuel.FuelType);
            textBoxPrice.Text = fuel.Price.ToString();
            comboBoxSupplier.SelectedValue = fuel.Supplier.Id;
            textBoxCount.Text = fuel.Count.ToString();
        }

        private bool CheckButton() => comboBoxSupplier.Items.Count != 0 ? true : false;

        private void FillComboBox()
        {
            foreach (FuelTypes dir in Enum.GetValues(typeof(FuelTypes)))
            {
                comboBoxType.Items.Add(new EnumConverter(dir));
            }
            comboBoxType.DisplayMember = nameof(EnumConverter.DislplayValue);
            comboBoxType.SelectedIndex = 0;

            comboBoxSupplier.DataSource = CommonClient.GetData<SupplierResponse>("Supplier/");
            comboBoxSupplier.DisplayMember = "Name";
            comboBoxSupplier.ValueMember = "Id";
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Fuel.FuelType = (FuelTypes)((EnumConverter)comboBoxType.SelectedItem).Type;
            Fuel.Price = double.TryParse(textBoxPrice.Text, out var capacity) ? capacity : 0.0;
            Fuel.SupplierId = (Guid)comboBoxSupplier.SelectedValue;
            Fuel.Count = double.TryParse(textBoxCount.Text, out var count) ? count : 0.0;
            if (!IsEdit)
            {
                Dialog = CommonClient.CreateData(Fuel, "Fuel/");
            }
            else
            {
                Dialog = CommonClient.UpdateData(Fuel, "Fuel/");
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

        private void comboBoxSupplier_Format(object sender, ListControlConvertEventArgs e)
        {
            var supplier = (SupplierResponse)e.ListItem;
            e.Value = $"{supplier.Name} | {supplier.Inn}";
        }
    }
}
