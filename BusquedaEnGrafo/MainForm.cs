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
            /*grafoDataGridView.Rows.Add("1", "2-200", true, false, 800);
            grafoDataGridView.Rows.Add("2", "1-200;3-150;4-350;5-450", false, false, 650);
            grafoDataGridView.Rows.Add("3", "2-150;5-400;6-225", false, false, 500);
            grafoDataGridView.Rows.Add("4", "2-350;5-300", false, false, 650);
            grafoDataGridView.Rows.Add("5", "2-450;3-400;4-300;7-250", false, false, 325);
            grafoDataGridView.Rows.Add("6", "3-225;7-450", false, false, 375);
            grafoDataGridView.Rows.Add("7", "5-250;6-450;8-125", false, false, 125);
            grafoDataGridView.Rows.Add("8", "7-125", false, true, 0);*/

            //Ejercicio TP3
            grafoDataGridView.Rows.Add("3", "4-400;13-300;14-500", false, false, 1970);
            grafoDataGridView.Rows.Add("4", "3-400;5-400;13-500;14-300;15-500", false, false, 1844);
            grafoDataGridView.Rows.Add("5", "4-400;6-400;14-500;15-300;16-500", false, false, 1800);
            grafoDataGridView.Rows.Add("6", "5-400;7-400;15-500;16-300;17-500", false, false, 1844);
            grafoDataGridView.Rows.Add("7", "6-400;8-400;16-500;17-300;18-500", false, false, 1970);
            grafoDataGridView.Rows.Add("8", "7-400;17-500;18-300", false, false, 2163);
            grafoDataGridView.Rows.Add("10", "20-300", false, false, 2691);
            grafoDataGridView.Rows.Add("13", "3-300;4-500;14-400;22-500;23-300;24-500", false, false, 1700);
            grafoDataGridView.Rows.Add("14", "3-500;4-300;5-500;13-400;15-400;23-500;24-300;25-500", false, false, 1552);
            grafoDataGridView.Rows.Add("15", "4-500;5-300;6-500;14-400;16-400;24-500;25-300;26-500", false, true, 1500);
            grafoDataGridView.Rows.Add("16", "5-500;6-300;7-500;15-400;17-400;25-500;26-300;27-500", false, false, 1552);
            grafoDataGridView.Rows.Add("17", "6-500;7-300;8-500;16-400;18-400;26-500;27-300;28-500", false, false, 1700);
            grafoDataGridView.Rows.Add("18", "7-500;8-300;17-400;27-500;28-300;29-500", false, false, 1921);
            grafoDataGridView.Rows.Add("20", "10-300;29-500;30-300", false, false, 2500);
            grafoDataGridView.Rows.Add("21", "22-400;32-500", false, false, 2000);
            grafoDataGridView.Rows.Add("22", "13-500;21-400;23-400;32-300;33-500", false, false, 1697);
            grafoDataGridView.Rows.Add("23", "13-300;14-500;22-400;24-400;32-500;33-300;34-500", false, false, 1442);
            grafoDataGridView.Rows.Add("24", "13-500;14-300;15-500;23-400;25-400;33-500;34-300;35-500", false, false, 1265);
            grafoDataGridView.Rows.Add("25", "14-500;15-300;16-500;24-400;26-400;34-500;35-300;36-500", false, false, 1200);
            grafoDataGridView.Rows.Add("26", "15-500;16-300;17-500;25-400;27-400;35-500;36-300;37-500", false, false, 1265);
            grafoDataGridView.Rows.Add("27", "16-500;17-300;18-500;26-400;28-400;36-500;37-300;38-500", false, false, 1442);
            grafoDataGridView.Rows.Add("28", "17-500;18-300;27-400;29-400;37-500;38-300;39-500", false, false, 1697);
            grafoDataGridView.Rows.Add("29", "18-500;20-500;28-400;30-400;38-500;39-300;40-500", false, false, 2000);
            grafoDataGridView.Rows.Add("30", "20-300;29-400;39-500;40-300", false, false, 2332);
            grafoDataGridView.Rows.Add("32", "21-500;22-300;23-500;33-400;41-500;42-300;43-500", false, false, 1500);
            grafoDataGridView.Rows.Add("33", "22-500;23-300;24-500;32-400;34-400;42-500;43-300", false, false, 1204);
            grafoDataGridView.Rows.Add("34", "23-500;24-300;25-500;33-400;35-400;43-500", false, false, 985);
            grafoDataGridView.Rows.Add("35", "24-500;25-300;26-500;34-400;36-400", false, false, 900);
            grafoDataGridView.Rows.Add("36", "25-500;26-300;27-500;35-400;37-400", false, false, 985);
            grafoDataGridView.Rows.Add("37", "26-500;27-300;28-500;36-400;38-400", false, false, 1204);
            grafoDataGridView.Rows.Add("38", "27-500;28-300;29-500;37-400;39-400", false, false, 1500);
            grafoDataGridView.Rows.Add("39", "28-500;29-300;30-500;38-400;40-400;50-500", false, false, 1836);
            grafoDataGridView.Rows.Add("40", "29-500;30-300;39-400;50-300", false, false, 2193);
            grafoDataGridView.Rows.Add("41", "32-500;42-400;51-300;52-500", false, false, 1709);
            grafoDataGridView.Rows.Add("42", "32-300;33-500;41-400;43-400;51-500;52-300;53-500", false, false, 1342);
            grafoDataGridView.Rows.Add("43", "32-500;33-300;34-500;42-400;52-500;53-300;54-500", false, false, 1000);
            grafoDataGridView.Rows.Add("50", "39-500;40-300;59-500;60-300", false, false, 2088);
            grafoDataGridView.Rows.Add("51", "41-300;42-500;52-400;61-300;62-500", false, false, 1628);
            grafoDataGridView.Rows.Add("52", "41-500;42-300;43-500;51-400;53-400;61-500;62-300", false, false, 1237);
            grafoDataGridView.Rows.Add("53", "42-500;43-300;52-400;54-400;62-500;64-500", false, false, 854);
            grafoDataGridView.Rows.Add("54", "43-500;53-400;55-400;64-300;65-500", false, false, 500);
            grafoDataGridView.Rows.Add("55", "54-400;64-500;65-300;66-500", false, false, 300);
            grafoDataGridView.Rows.Add("57", "66-500;67-300", false, false, 854);
            grafoDataGridView.Rows.Add("59", "50-500;60-400;69-300;70-500", false, false, 1628);
            grafoDataGridView.Rows.Add("60", "50-300;59-400;69-500;70-300", false, false, 2022);
            grafoDataGridView.Rows.Add("61", "51-300;52-500;62-400;71-300", false, false, 1600);
            grafoDataGridView.Rows.Add("62", "51-500;52-300;53-500;61-400;71-500", false, false, 1200);
            grafoDataGridView.Rows.Add("64", "53-500;54-300;55-500;65-400;74-300;75-500", false, false, 400);
            grafoDataGridView.Rows.Add("65", "54-500;55-300;64-400;66-400;74-500;75-300;76-500", true, false, 0);
            grafoDataGridView.Rows.Add("66", "55-500;57-500;65-400;67-400;75-500;76-300;77-500", false, false, 400);
            grafoDataGridView.Rows.Add("67", "57-300;66-400;76-500;77-300", false, false, 800);
            grafoDataGridView.Rows.Add("69", "59-300;60-500;70-400;79-300;80-500", false, false, 1600);
            grafoDataGridView.Rows.Add("70", "59-500;60-300;69-400;79-500;80-300", false, false, 2022);
            grafoDataGridView.Rows.Add("71", "61-300;62-500;81-300;82-500", false, false, 1628);
            grafoDataGridView.Rows.Add("74", "64-300;65-500;75-400;84-300;85-500", false, false, 500);
            grafoDataGridView.Rows.Add("75", "64-500;65-300;66-500;74-400;76-400;84-500;85-300;86-500", false, false, 300);
            grafoDataGridView.Rows.Add("76", "65-500;66-300;67-500;75-400;77-400;85-500;86-300;87-500", false, false, 500);
            grafoDataGridView.Rows.Add("77", "66-500;67-300;76-400;86-500;87-300;88-500", false, false, 854);
            grafoDataGridView.Rows.Add("79", "69-300;70-500;80-400;88-500;89-300;90-500", false, false, 1628);
            grafoDataGridView.Rows.Add("80", "69-500;70-300;79-400;89-500;90-300", false, false, 2088);
            grafoDataGridView.Rows.Add("81", "71-300;82-400;91-300;92-500", false, false, 1709);
            grafoDataGridView.Rows.Add("82", "71-500;81-400;91-500;92-300;93-500", false, false, 1342);
            grafoDataGridView.Rows.Add("84", "74-300;75-500;85-400;93-500;94-300;95-500", false, false, 721);
            grafoDataGridView.Rows.Add("85", "74-500;75-300;76-500;84-400;86-400;94-500;95-300;96-500", false, false, 600);
            grafoDataGridView.Rows.Add("86", "75-500;76-300;77-500;85-400;87-400;95-500;96-300;97-500", false, false, 721);
            grafoDataGridView.Rows.Add("87", "76-500;77-300;86-400;88-400;96-500;97-300", false, false, 1000);
            grafoDataGridView.Rows.Add("88", "77-500;79-500;87-400;89-400;97-500", false, false, 1342);
            grafoDataGridView.Rows.Add("89", "79-300;80-500;88-400;90-400", false, false, 1709);
            grafoDataGridView.Rows.Add("90", "79-500;80-300;89-400", false, false, 2193);
            grafoDataGridView.Rows.Add("91", "81-300;82-500;92-400", false, false, 1836);
            grafoDataGridView.Rows.Add("92", "81-500;82-300;91-400;93-400", false, false, 1500);
            grafoDataGridView.Rows.Add("93", "82-500;84-500;92-400;94-400", false, false, 1204);
            grafoDataGridView.Rows.Add("94", "84-300;85-500;93-400;95-400", false, false, 985);
            grafoDataGridView.Rows.Add("95", "84-500;85-300;86-500;94-400;96-400", false, false, 900);
            grafoDataGridView.Rows.Add("96", "85-500;86-300;87-500;95-400;97-400", false, false, 985);
            grafoDataGridView.Rows.Add("97", "86-500;87-300;88-500;96-400", false, false, 1204);
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
