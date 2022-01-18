using System.Windows.Forms;

namespace TTask.Styles
{
    public static class DataGridViewStyles
    {
        public static void SetMatrixStyle(this DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
        }
    }
}
