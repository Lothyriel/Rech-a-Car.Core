using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public static class DataGridViewExtensions
    {
        public static void ConfigurarGridZebrado(this DataGridView grid)
        {
            Font font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            grid.AlternatingRowsDefaultCellStyle = linhaEscura;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = font,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            grid.RowsDefaultCellStyle = linhaClara;
        }
        public static void ConfigurarGridSomenteLeitura(this DataGridView grid)
        {
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            grid.BorderStyle = BorderStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            grid.MultiSelect = false;
            grid.ReadOnly = true;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoGenerateColumns = false;

            grid.AllowUserToResizeRows = false;

            grid.RowsAdded += (sender, e) =>
            {
                grid.ClearSelection();
            };

            grid.RowsRemoved += (sender, e) =>
            {
                grid.ClearSelection();
            };
        }
        public static DataGridViewRow GetLinhaSelecionada(this DataGridView grid)
        {
            const int primeira = 0;

            return grid.SelectedRows[primeira];
        }
        public static int GetIdSelecionado(this DataGridView grid)
        {
            const int coluna_id = 0;
            var linha = grid.GetLinhaSelecionada();
            return (int)linha.Cells[coluna_id].Value;
        }
        public static void ConfigurarGrid(this DataGridView grid, DataGridViewColumn[] colunas)
        {
            grid.Columns.Clear();

            var colunaID = new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID" };
            colunaID.Visible = false;
            grid.Columns.Add(colunaID);
            grid.Columns.AddRange(colunas);

            grid.ConfigurarGridSomenteLeitura();
        }
    }
}
