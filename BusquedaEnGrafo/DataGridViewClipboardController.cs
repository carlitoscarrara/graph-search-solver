using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaEnGrafo
{
    public static class DataGridViewClipboardController
    {
        //Metodo encargado de realizar el pegado de lo copiado en el clipboard
        public static void pasteClipboard(DataGridView dataGridView)
        {
            try
            {
                //Obtener la data del clipboard en forma de matriz
                string[,] clipboardDataMatrix = getMatrixDataFromClipboard();
                int clipboardDataMatrixRows = clipboardDataMatrix.GetLength(0);
                int clipboardDataMatrixColumns = clipboardDataMatrix.GetLength(1);

                //Obtener info de las celdas seleccionadas para pegar
                DataGridViewSelectedCellCollection selectedCells = dataGridView.SelectedCells;
                int selectedCellsRows = selectedCells.Cast<DataGridViewCell>().Select(x => x.RowIndex).Distinct().Count();
                int selectedCellsColumns = selectedCells.Cast<DataGridViewCell>().Select(x => x.ColumnIndex).Distinct().Count();
                int selectedCellsStartRow = selectedCells.Cast<DataGridViewCell>().Select(x => x.RowIndex).Distinct().Min();
                int selectedCellsStartColumn = selectedCells.Cast<DataGridViewCell>().Select(x => x.ColumnIndex).Distinct().Min();

                //Obtener info de las DataGridView
                int dataGridViewRows = dataGridView.RowCount;
                int dataGridViewColumns = dataGridView.ColumnCount;

                //Comparar el tamaño de la data copiada con el tamaño de las celdas seleccionadas

                //Si copio una sola celda
                if (clipboardDataMatrixRows == 1 && clipboardDataMatrixColumns == 1)
                {
                    string copiedValue = clipboardDataMatrix[0, 0];

                    foreach (DataGridViewCell selectedCell in selectedCells)
                    {
                        if (!selectedCell.ReadOnly)
                        {
                            selectedCell.Value = copiedValue;
                        }
                    }
                }

                //Si copio mas de una celda
                if (clipboardDataMatrix.Length > 1)
                {
                    //Y tengo la misma matriz seleccionada
                    bool sameSelectedMatixSize = clipboardDataMatrixRows == selectedCellsRows && clipboardDataMatrixColumns == selectedCellsColumns;
                    //O tengo una sola celda seleccionada
                    bool selectedOnlyOneCell = selectedCellsRows == 1 && selectedCellsColumns == 1;

                    if (sameSelectedMatixSize || selectedOnlyOneCell)
                    {
                        //Verificar que haya espacio para pegar
                        bool thereAreEnoughCells = selectedCellsStartRow + clipboardDataMatrixRows <= dataGridViewRows && selectedCellsStartColumn + clipboardDataMatrixColumns <= dataGridViewColumns;
                        if (thereAreEnoughCells)
                        {
                            for (int i = 0; i < clipboardDataMatrixRows; i++)
                            {
                                for (int j = 0; j < clipboardDataMatrixColumns; j++)
                                {
                                    int rowIndex = selectedCellsStartRow + i;
                                    int columnIndex = selectedCellsStartColumn + j;

                                    if (!dataGridView[columnIndex, rowIndex].ReadOnly)
                                    {
                                        dataGridView[columnIndex, rowIndex].Value = clipboardDataMatrix[i, j];
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem pasting clipboard data: " + ex.Message);
            }

        }

        //Transformar la información del Clipboard en una matriz de strings
        public static string[,] getMatrixDataFromClipboard()
        {
            try
            {
                //La data copiada tiene el siente formato:  CeldaA1\tCeldaB1\tCeldaC1\r\nCeldaA2\tCeldaB2\tCeldaC2\r\nCeldaA3\tCeldaB3\tCeldaC3
                string clipboardData = (string)Clipboard.GetData(DataFormats.Text);

                //Eliminar el ultimo return que agrega el copiado desde Excel
                if (clipboardData.EndsWith("\r\n"))
                {
                    clipboardData = clipboardData.Substring(0, clipboardData.Length - 2); // TODO: NO HACER MAGICO LA LONGITUD
                }

                //Convertir la clipboardData en una matriz con sus elementos
                int rowsCount = Regex.Matches(clipboardData, "\r\n").Count + 1;
                int columnCount = (Regex.Matches(clipboardData, "\t").Count + rowsCount) / rowsCount;

                string[,] clipboardDataMatrix = new string[rowsCount, columnCount];

                string[] clipboardDataRows = clipboardData.Split(new string[] { "\r\n" }, StringSplitOptions.None);

                for (int i = 0; i < clipboardDataRows.Length; i++)
                {
                    string[] clipboardDataCells = clipboardDataRows[i].Split(new string[] { "\t" }, StringSplitOptions.None);

                    for (int j = 0; j < clipboardDataCells.Length; j++)
                    {
                        clipboardDataMatrix[i, j] = "";

                        if (clipboardDataCells[j] != null)
                        {
                            clipboardDataMatrix[i, j] = clipboardDataCells[j];
                        }
                    }
                }

                return clipboardDataMatrix;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem reading the data from the clipboard: " + ex.Message);
                return null;
            }

        }
    }

}
