using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaEnGrafo
{
    public class Busqueda
    {

        /// <summary>
        /// Metodo general de busqueda
        /// </summary>
        /// <param name="mainForm">Formulario principal. Necesario para obtener los datos del grafo original</param>
        /// <param name="nodoInicial">Nodo incial de la busqueda</param>
        /// <param name="nodoFinal">Nodo final de la busqueda</param>
        /// <param name="searchType">Tipo de busqueda a realizar</param>
        /// <param name="cantidadIteraciones">Cantidad de iteraciones necearias para realizar la búsqueda.</param>
        /// <returns></returns>
        public List<Node> graphSearch(MainForm mainForm, Node nodoInicial, Node nodoFinal, Ctes.SearchType searchType, ref int cantidadIteraciones)
        {
            Node nodoSolucion = null;
            cantidadIteraciones = 0;

            ListaFrontera nodosPorVisitar = new ListaFrontera(searchType);
            List<Node> nodosVisitados = new List<Node>();

            nodosPorVisitar.AddNode(nodoInicial);

            bool solucionEncontrada = false;

            //Recorrer la lista frontera
            while (nodosPorVisitar.Count > 0 && !solucionEncontrada)
            {
                cantidadIteraciones++;

                //Obtener el siguiente nodo de la lista frontera
                Node nodoPuntero = nodosPorVisitar.getNextNode();

                //Agregarlo a la lista cerrada
                nodosVisitados.Add(nodoPuntero);

                //Expandir el nodo (recorrer los nodos vecinos o conexiones)
                //foreach (Node nodoConexion in nodoPuntero.conexiones.Keys)
                foreach (KeyValuePair<Node, int> conexion in nodoPuntero.conexiones)
                {
                    //Hacemos una copia del nodo vecino. Pasa a ser un nodo hijo cuyo padre es el puntero
                    Node nodoHijo = mainForm.getGraphFromGrid().Where(n => n.value == conexion.Key.value).First();
                    nodoHijo.nodoPadre = nodoPuntero;
                    nodoHijo.costeAcumulado = nodoPuntero.costeAcumulado + conexion.Value;

                    //Si es el nodo final
                    if (nodoHijo.value == nodoFinal.value)
                    {
                        solucionEncontrada = true;
                        nodoSolucion = nodoHijo;
                    }
                    //Sino es el nodo final
                    else
                    {
                        bool estaEnNodosVisitados = nodosVisitados.Select(n => n.value).Contains(nodoHijo.value);
                        if (!estaEnNodosVisitados)
                        {
                            nodosPorVisitar.AddNode(nodoHijo);
                        }                        
                    }
                }
            }

            // Armar el camino realizado para llegar al nodo final
            List<Node> caminoSolucion = new List<Node>();

            Node nodoCaminoEnSolucion = nodoSolucion;
            while (nodoCaminoEnSolucion.nodoPadre != null)
            {
                caminoSolucion.Add(nodoCaminoEnSolucion);
                nodoCaminoEnSolucion = nodoCaminoEnSolucion.nodoPadre;
            }

            caminoSolucion.Add(nodoInicial);

            caminoSolucion.Reverse();

            return caminoSolucion;
        }

    }
}
