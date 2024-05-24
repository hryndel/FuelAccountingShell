using System.Drawing;
using System.Windows.Forms;

namespace FuelAccountingShell.Infrastructure.Styles
{
    public static class DataGridVeiwStyle
    {
        public static void Stylization(this DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(58, 58, 58); ;
            dgv.EnableHeadersVisualStyles = true;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.MultiSelect = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoGenerateColumns = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200);
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 100, 100);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(126, 126, 126);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
