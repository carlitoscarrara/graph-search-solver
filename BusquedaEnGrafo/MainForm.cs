using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaEnGrafo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Carga inicial de un grafo de ejemplo en la grilla
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Ejercicio Habitaciones
            /*grafoDataGridView.Rows.Add("A", "B", false, false);
            grafoDataGridView.Rows.Add("B", "A;C", false, false);
            grafoDataGridView.Rows.Add("C", "B;F", true, false);
            grafoDataGridView.Rows.Add("D", "E;G", false, false);
            grafoDataGridView.Rows.Add("E", "B;D;F;H", false, false);
            grafoDataGridView.Rows.Add("F", "C;E;H", false, false);
            grafoDataGridView.Rows.Add("G", "D;H", false, true);
            grafoDataGridView.Rows.Add("H", "E;F;G", false, false);*/

            //Ejercicio ciudades
            grafoDataGridView.Rows.Add("1", "2-200", true, false, 800);
            grafoDataGridView.Rows.Add("2", "1-200;3-150;4-350;5-450", false, false, 650);
            grafoDataGridView.Rows.Add("3", "2-150;5-400;6-225", false, false, 500);
            grafoDataGridView.Rows.Add("4", "2-350;5-300", false, false, 650);
            grafoDataGridView.Rows.Add("5", "2-450;3-400;4-300;7-250", false, false, 325);
            grafoDataGridView.Rows.Add("6", "3-225;7-450", false, false, 375);
            grafoDataGridView.Rows.Add("7", "5-250;6-450;8-125", false, false, 125);
            grafoDataGridView.Rows.Add("8", "7-125", false, true, 0);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Get values from the form
            Ctes.SearchType searchType = Ctes.SearchType.fifoSearch; //By default fifo

            if (fifoTypeRadioButton.Checked)
            {
                searchType = Ctes.SearchType.fifoSearch;
            }
            if (lifoTypeRadioButton.Checked)
            {
                searchType = Ctes.SearchType.lifoSearch;
            }
            if (aVaraRadioButton.Checked)
            {
                searchType = Ctes.SearchType.aVaraSearch;
            }
            if (aEstrellaRadioButton.Checked)
            {
                searchType = Ctes.SearchType.aEstrellaSearch;
            }

            Node nodoInicial = getInitialNodeFromGrid();
            Node nodoFinal = getFinalNodeFromGrid();

            Busqueda busqueda = new Busqueda();
            List<Node> caminoSolucion = new List<Node>();
            int cantidadIteraciones = 0;
            caminoSolucion = busqueda.graphSearch(this, nodoInicial, nodoFinal, searchType, ref cantidadIteraciones);


            string mensajeFinal =
                "Método de búsqueda: "
                + searchType.ToString()
                + "\n"
                + "\nCamino solución:"
                + "\n" + String.Join("-", caminoSolucion)
                + "\n"
                + "\nCantidad de iteraciones: "
                + "\n" + cantidadIteraciones.ToString();

            MessageBox.Show(mensajeFinal);
        }

        private void grafoDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            //Pegar en Ctrl + V
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                DataGridViewClipboardController.pasteClipboard(grafoDataGridView);
            }

        }

        //Convierte los datos de la grilla a un listado de nodos, es decir, a un grafo
        public List<Node> getGraphFromGrid()
        {
            int rowCount = grafoDataGridView.RowCount;

            //Primero creamos todos los nodos
            Node[] nodos = new Node[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewRow row = grafoDataGridView.Rows[i];
                if (row.Cells["nodeColumn"].Value != null)
                {
                    nodos[i] = new Node(row.Cells["nodeColumn"].Value.ToString());
                }

                if (row.Cells["heuristicaColumn"].Value != null)
                {
                    nodos[i].heuristica = Int32.Parse(row.Cells["heuristicaColumn"].Value.ToString());
                }
            }

            //Luego se agregan las conexiones
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewRow row = grafoDataGridView.Rows[i];
                if (row.Cells["nodeColumn"].Value != null)
                {
                    if (row.Cells["conecctionsColumn"].Value != null)
                    {
                        Dictionary<Node, int> connectionsList = new Dictionary<Node, int>();
                        foreach (string connection in row.Cells["conecctionsColumn"].Value.ToString().Split(';'))
                        {
                            if (connection.Contains("-"))
                            {
                                connectionsList.Add(nodos.Where(n => n.value == connection.Split('-')[0]).First(), Int32.Parse(connection.Split('-')[1]));
                            } else
                            {
                                connectionsList.Add(nodos.Where(n => n.value == connection).First(), 0);
                            }                            
                        }

                        nodos[i].conexiones = connectionsList;
                    }
                }
            }

            return nodos.ToList();
        }

        //Obtiene el nodo inicial
        private Node getInitialNodeFromGrid()
        {
            Node nodo = new Node();

            int rowCount = grafoDataGridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewRow row = grafoDataGridView.Rows[i];
                if (row.Cells["nodeColumn"].Value != null)
                {
                    if (row.Cells["initialNodeColumn"].Value != null)
                    {
                        Boolean.TryParse(row.Cells["initialNodeColumn"].Value.ToString(), out bool isInitialNode);

                        if (isInitialNode)
                        {
                            nodo = getGraphFromGrid().Where(n => n.value == row.Cells["nodeColumn"].Value.ToString()).First();
                        }
                    }
                }
            }

            return nodo;
        }

        //Obtiene el nodo final
        private Node getFinalNodeFromGrid()
        {
            Node nodo = new Node();

            int rowCount = grafoDataGridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                DataGridViewRow row = grafoDataGridView.Rows[i];
                if (row.Cells["nodeColumn"].Value != null)
                {
                    if (row.Cells["finalNodeColumn"].Value != null)
                    {
                        Boolean.TryParse(row.Cells["finalNodeColumn"].Value.ToString(), out bool isFinalNode);

                        if (isFinalNode)
                        {
                            nodo = getGraphFromGrid().Where(n => n.value == row.Cells["nodeColumn"].Value.ToString()).First();
                        }
                    }
                }
            }

            return nodo;
        }
    }
}
