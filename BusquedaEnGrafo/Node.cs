using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaEnGrafo
{
    public class Node
    {
        public string value { get; set; }
        public Node nodoPadre;
        public Dictionary<Node, int> conexiones { get; set; } //Dictionary<Nodo, costo>
        public int heuristica = 0;
        public int costeAcumulado = 0;

        public int heuristicaMasCosteAcumulado
        {
            get
            {
                return heuristica + costeAcumulado;
            }
        }

        public Node(string value = null)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return this.value;
        }
    }
}
