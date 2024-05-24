using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.FuelAccountingItem;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlFuelAccountingItem : UserControl
    {
        public UserControlFuelAccountingItem()
        {
            InitializeComponent(); 
            DataGridVeiwStyle.Stylization(dataGridViewFuelAccountingItems);
        }
        
        private async void UserControlFuelAccountingItem_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<FuelAccountingItemResponse>("FuelAccountingItem/");
            dataGridViewFuelAccountingItems.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewFuelAccountingItems.Rows.Count} из {items.Count}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditFuelAccountingItem form = new FormAddEditFuelAccountingItem();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditFuelAccountingItem form = new FormAddEditFuelAccountingItem("test");
            form.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show(JSonWebToken.Token);
        }
    }
}
