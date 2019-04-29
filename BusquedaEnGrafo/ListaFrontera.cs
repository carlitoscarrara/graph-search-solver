using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaEnGrafo
{
    // Clase que maneja los distintos comportamientos de la lista frontera según el tipo de busqueda
    public class ListaFrontera
    {
        Ctes.SearchType searchType;

        private Queue<Node> queue; //Usado en busqueda por anchura
        private Stack<Node> stack; //Usada en busqueda por profundidad
        private List<Node> list; //Usada en busquedas informadas

        //Devuelve la cantidad de elementos del listado que corresponda segun el tipo de busqueda
        public int Count {
            get
            {
                switch (searchType)
                {
                    case Ctes.SearchType.fifoSearch:
                        return queue.Count;
                    case Ctes.SearchType.lifoSearch:
                        return stack.Count;
                    case Ctes.SearchType.aVaraSearch:
                    case Ctes.SearchType.aEstrellaSearch:
                        return list.Count;
                    default:
                        return 0;
                }
            }

        }

        //Construcutor. Inicializa el listado que corresponda segun el tipo de busqueda
        public ListaFrontera(Ctes.SearchType searchType)
        {
            this.searchType = searchType;

            switch (searchType)
            {
                case Ctes.SearchType.fifoSearch:
                    queue = new Queue<Node>();
                    break;
                case Ctes.SearchType.lifoSearch:
                    stack = new Stack<Node>();
                    break;
                case Ctes.SearchType.aVaraSearch:
                case Ctes.SearchType.aEstrellaSearch:
                    list = new List<Node>();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Agregar un nodo al listado que corresponda segun el tipo de busqueda
        /// </summary>
        /// <param name="node">Nodo a agregar al listado</param>
        public void AddNode(Node node)
        {
            switch (searchType)
            {
                case Ctes.SearchType.fifoSearch:
                    bool estaEnQueue = queue.Select(n => n.value).Contains(node.value);

                    if (!estaEnQueue)
                        queue.Enqueue(node);
                    break;
                case Ctes.SearchType.lifoSearch:
                    bool estaEnStack = stack.Select(n => n.value).Contains(node.value);

                    if (!estaEnStack)
                        stack.Push(node);
                    break;
                case Ctes.SearchType.aVaraSearch:
                    bool estaEnList = list.Select(n => n.value).Contains(node.value);

                    if (!estaEnList)
                        list.Add(node);
                    break;
                case Ctes.SearchType.aEstrellaSearch:
                    list.Add(node); //No le importa si ya estan enlistados
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Obtiene el siguiente nodo del listado y lo quita del mismo
        /// </summary>
        /// <returns>El nodo siguiente</returns>
        public Node getNextNode()
        {
            Node nextNode;

            switch (searchType)
            {
                case Ctes.SearchType.fifoSearch:
                    nextNode = queue.Dequeue();
                    break;
                case Ctes.SearchType.lifoSearch:
                    nextNode = stack.Pop();
                    break;
                case Ctes.SearchType.aVaraSearch:
                    list = list.OrderBy(n => n.heuristica).ToList(); //Los ordena segun su valor de heuristica
                    nextNode = list.First();
                    list.Remove(nextNode);
                    break;
                case Ctes.SearchType.aEstrellaSearch:
                    list = list.OrderBy(n => n.heuristicaMasCosteAcumulado).ToList();  //Los ordena segun su valor de heuristica más el coste acumulado
                    nextNode = list.First();
                    list.Remove(nextNode);
                    break;
                default:
                    nextNode = null;
                    break;
            }

            return nextNode;
        }

        
    }
}
