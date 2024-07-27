using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vista.Utilidad
{
    public class DGVDisenio
    {
        private static bool columnasIniciadas = true;

        //Método para dar formato al DataGridView, recibimos dos paramateros uno tipo DataGrid y otro int para la selección del color.
        
        public static void Formato(DataGridView pData, bool editar)
        { // Fuente para las filas
            pData.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
            // Fuente para las columnas
            pData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            // Ancho de columnas
            // Alto de las filas
            pData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // No se agregan columnas automáticamente
            pData.AutoGenerateColumns = false;
            // Borders Generales
            pData.BorderStyle = BorderStyle.FixedSingle;
            pData.EnableHeadersVisualStyles = false;
            pData.RowHeadersVisible = false;
            pData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            // Color de letra de las columnas
            pData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // Bordes de celdas
            pData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            pData.GridColor = Color.LightGray;
            // Estilo de selección
            pData.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            pData.DefaultCellStyle.SelectionForeColor = Color.Black;

            pData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            // Columna
            pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64);
            // Fila
            pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 192);
            pData.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            pData.RowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);
            // Fila alternativa
            pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 192);
            pData.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
            pData.AlternatingRowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);

            if (editar)
            {
                DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
                DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();

                colEditar.Text = "Editar";
                colEditar.Name = "Editar";
                colEditar.UseColumnTextForButtonValue = true;


                colEliminar.Text = "Eliminar";
                colEliminar.Name = "Eliminar";
                colEliminar.UseColumnTextForButtonValue = true;

                pData.Columns.Add(colEditar);
                pData.Columns.Add(colEliminar);

                columnasIniciadas = true;
            }

        }
    }

}
