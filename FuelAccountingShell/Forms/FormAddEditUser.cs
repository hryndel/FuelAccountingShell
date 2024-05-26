using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Infrastructure.WorkWithEnums;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.User;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.Forms
{
    public partial class FormAddEditUser : MaterialForm
    {
        private UserRequest User = new UserRequest();
        private bool IsEdit = false;
        private DialogResult Dialog = DialogResult.None;

        public FormAddEditUser()
        {
            InitializeComponent(); 
            InitMaterialSkin.StylizationUI(this);
            FillComboBox();
        }

        public FormAddEditUser(UserResponse user) : this()
        {
            IsEdit = true;
            buttonAccept.Text = "Изменить";
            
            User.Id = user.Id;
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
            textBoxPatronymic.Text = user.Patronymic;
            textBoxMail.Text = user.Mail;
            textBoxLogin.Text = user.Login;
            comboBoxUserType.SelectedItem = comboBoxUserType.Items.Cast<EnumConverter>().FirstOrDefault(x => (UserTypes)x.Type == user.UserType);

        }

        private void FillComboBox()
        {
            foreach (UserTypes dir in Enum.GetValues(typeof(UserTypes)))
            {
                comboBoxUserType.Items.Add(new EnumConverter(dir));
            }
            comboBoxUserType.DisplayMember = nameof(EnumConverter.DislplayValue);
            comboBoxUserType.SelectedIndex = 0;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            User.FirstName = textBoxFirstName.Text.Trim();
            User.LastName = textBoxLastName.Text.Trim();
            User.Patronymic = textBoxPatronymic.Text.Trim();
            User.Mail = textBoxMail.Text.Trim();
            User.Login = textBoxLogin.Text.Trim();
            User.Password = textBoxPassword.Text.Trim();
            User.UserType = (UserTypes)((EnumConverter)comboBoxUserType.SelectedItem).Type;
            if (!IsEdit)
            {
                Dialog = CommonClient.CreateData(User, "User/");
            }
            else
            {
                Dialog = CommonClient.UpdateData(User, "User/");
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
