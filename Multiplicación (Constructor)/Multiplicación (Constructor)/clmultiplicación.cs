using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicación__Constructor_
{
    internal class clmultiplicación
    {
        // Propiedades, campos, etc.
        private int n1;
        private int n2;

        // Constructor.
        public clmultiplicación(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        // Metodos.
        public int Multiplicar()
        {
            return n1 * n2;
        }
    }
}
