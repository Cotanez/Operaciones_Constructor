using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resta__Constructor_
{
    internal class clresta
    {
        // Propiedades, campos, etc.
        private int n1;
        private int n2;

        // Constructor
        public clresta(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        // Metodos
        public int Resta()
        {
            return n1 - n2;
        }
    }
}
