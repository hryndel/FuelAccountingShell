using FuelAccountingShell.Forms;
using FuelAccountingShell.Infrastructure;
using FuelAccountingShell.Infrastructure.Styles;
using FuelAccountingShell.Models.Enums;
using FuelAccountingShell.Models.Trailer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FuelAccountingShell.UserControls
{
    public partial class UserControlTrailer : UserControl
    {
        private List<TrailerResponse> Trailers;

        public UserControlTrailer()
        {
            InitializeComponent(); 
            DataGridVeiwStyle.Stylization(dataGridViewTrailers);
            if (!this.DesignMode)
            {
                materialListBoxSort.SelectedIndex = 0;
            }
        }

        public void UserControlTrailer_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            Trailers = CommonClient.GetData<TrailerResponse>("Trailer/");
            if (CloseForms.SystemClosing) return;
            dataGridViewTrailers.DataSource = Trailers;
            labelStatus.Text = $"Количество записей: {dataGridViewTrailers.Rows.Count} из {Trailers.Count}";

            buttonEdit.Enabled = buttonDelete.Enabled = (CheckCountRows.CheckCount(dataGridViewTrailers.Rows.Count) && JSonWebToken.UserTypes != UserTypes.Employee);
            buttonAdd.Enabled = JSonWebToken.UserTypes != UserTypes.Employee;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddEditTrailer form = new FormAddEditTrailer();
            form.ShowDialog();
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormAddEditTrailer form = new FormAddEditTrailer((TrailerResponse)dataGridViewTrailers.CurrentRow.DataBoundItem);
            form.ShowDialog();
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CommonClient.DeleteData(((TrailerResponse)dataGridViewTrailers.CurrentRow.DataBoundItem).Id, "Trailer/");
            LoadData();
        }

        private void SearchAndSort()
        {
            var items = Trailers.Where(x => x.Name.ToLower().Contains(textBoxSearch.Text.ToLower())).ToList();
            switch (materialListBoxSort.SelectedIndex)
            {
                case 0:
                    dataGridViewTrailers.DataSource = items;
                    break;
                case 1:
                    items.Sort((a, b) => a.Capacity.CompareTo(b.Capacity));
                    break;
                case 2:
                    items.Sort((a, b) => b.Capacity.CompareTo(a.Capacity));
                    break;
            }
            dataGridViewTrailers.DataSource = items;
            labelStatus.Text = $"Количество записей: {dataGridViewTrailers.Rows.Count} из {Trailers.Count}";
        }

        private void materialListBoxSort_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            SearchAndSort();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAndSort();
        }
    }
}
