using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAuthorization : MaterialForm
    {
        public FormAuthorization()
        {
            InitializeComponent();
            InitMaterialSkin.StylizationUI(this);
        }

        private async void buttonEnter_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                var result = await CommonClient.SignIn(textBoxLogin.Text, textBoxPassword.Text);
                if (result)
                {
                    this.Hide();
                    FormMain form = new FormMain();
                    form.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MaterialMessageBox.Show("Некорректные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, false, FlexibleMaterialForm.ButtonsPosition.Fill);
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
