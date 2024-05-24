using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.User;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlUser : UserControl
    {
        public UserControlUser()
        {
            InitializeComponent();
            DataGridVeiwStyle.Stylization(dataGridViewUsers);
        }

        private async void UserControlUser_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<UserResponse>("User/");
            dataGridViewUsers.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewUsers.Rows.Count} из {items.Count}";
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditUser form = new FormAddEditUser();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditUser form = new FormAddEditUser("test");
            form.ShowDialog();
        }
    }
}
