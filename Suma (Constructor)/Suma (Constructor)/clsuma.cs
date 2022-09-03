using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma__Constructor_
{
    internal class clsuma
    {
        // Propiedades, campos, etc.
        private int n1;
        private int n2;

        // Constructor.
        public clsuma(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        // Metodos.
        public int Suma()
        {
            return n1 + n2;
        }
    }
}
