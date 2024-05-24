using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Trailer;
using System;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlTrailer : UserControl
    {
        public UserControlTrailer()
        {
            InitializeComponent(); 
            DataGridVeiwStyle.Stylization(dataGridViewTrailers);
        }

        private async void UserControlTrailer_Load(object sender, EventArgs e)
        {
            var items = await CommonClient.GetData<TrailerResponse>("Trailer/");
            dataGridViewTrailers.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewTrailers.Rows.Count} из {items.Count}";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditTrailer form = new FormAddEditTrailer();
            form.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditTrailer form = new FormAddEditTrailer("test");
            form.ShowDialog();
        }
    }
}
