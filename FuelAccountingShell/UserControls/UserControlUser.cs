using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.User;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlUser : UserControl
    {
        private List<UserResponse> Users;
        public UserControlUser()
        {
            InitializeComponent();
            FillListBox();
            DataGridVeiwStyle.Stylization(dataGridViewUsers);
        }

        private async void UserControlUser_Load(object sender, EventArgs e)
        {
            materialListBoxRoles.SelectedIndex = 0;

            Users = await CommonClient.GetData<UserResponse>("User/");
            dataGridViewUsers.DataSource = Users;
            labelStatus.Text = $"Количество записей: {dataGridViewUsers.Rows.Count} из {Users.Count}";
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

        private void FillListBox()
        {
            materialListBoxRoles.Items.Clear();
            materialListBoxRoles.Items.Add(new MaterialListBoxItem("По умолчанию"));
            foreach (UserTypes dir in Enum.GetValues(typeof(UserTypes)))
            {
                var materialSkikItem = new MaterialListBoxItem();
                materialSkikItem.Text = dir.EnumConvert();
                materialSkikItem.Tag = dir;
                materialListBoxRoles.Items.Add(materialSkikItem);
            }
            materialListBoxRoles.SelectedIndex = 0;
        }

        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewUsers.Columns[e.ColumnIndex].DataPropertyName == "UserType")
            {
                var myStatus = EnumReader.ParseEnum<UserTypes>(e.Value.ToString());
                e.Value = myStatus.EnumConvert();
            }
        }

        public void SearchAndFiltr()
        {
            var data = materialListBoxRoles.SelectedItem;
            if (data.Tag is UserTypes enm)
            {
                dataGridViewUsers.DataSource = Users.Where(x => x.UserType == enm.ToString() && x.Login.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            }
            else
            {
                dataGridViewUsers.DataSource = Users.Where(x => x.Login.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            }
            labelStatus.Text = $"Количество записей: {dataGridViewUsers.Rows.Count} из {Users.Count}";
        }

        private void materialListBoxRoles_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            SearchAndFiltr();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAndFiltr();
        }
    }
}
