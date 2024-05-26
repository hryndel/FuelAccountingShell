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
            DataGridVeiwStyle.Stylization(dataGridViewUsers);
            if (!this.DesignMode)
            {
                FillListBox();
            }
        }

        public void UserControlUser_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Users = CommonClient.GetData<UserResponse>("User/");
            if (CloseForms.SystemClosing) return;
            dataGridViewUsers.DataSource = Users;
            labelStatus.Text = $"Количество записей: {dataGridViewUsers.Rows.Count} из {Users.Count}";

            buttonEdit.Enabled = buttonDelete.Enabled = CheckCountRows.CheckCount(dataGridViewUsers.Rows.Count);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditUser form = new FormAddEditUser();
            form.ShowDialog();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditUser form = new FormAddEditUser((UserResponse)dataGridViewUsers.CurrentRow.DataBoundItem);
            form.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommonClient.DeleteData(((UserResponse)dataGridViewUsers.CurrentRow.DataBoundItem).Id, "User/");
            LoadData();
        }

        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewUsers.Columns[e.ColumnIndex].DataPropertyName == "UserType")
            {
                var type = (UserTypes)e.Value;
                e.Value = type.EnumRead();
            }
        }

        private void SearchAndFiltr()
        {
            if (materialListBoxRoles.SelectedItem.Tag is UserTypes enm)
            {
                dataGridViewUsers.DataSource = Users.Where(x => x.UserType.ToString() == enm.ToString() && x.Login.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
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

        private void FillListBox()
        {
            materialListBoxRoles.Items.Clear();
            materialListBoxRoles.Items.Add(new MaterialListBoxItem("По умолчанию"));
            foreach (UserTypes dir in Enum.GetValues(typeof(UserTypes)))
            {
                var materialSkikItem = new MaterialListBoxItem();
                materialSkikItem.Text = dir.EnumRead();
                materialSkikItem.Tag = dir;
                materialListBoxRoles.Items.Add(materialSkikItem);
            }
            materialListBoxRoles.SelectedIndex = 0;
            materialListBoxRoles.SelectedIndex = 0;
        }
    }
}
