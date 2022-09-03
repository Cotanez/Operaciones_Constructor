using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace División__Constructor_
{
    internal class cldivisión
    {
        // Propiedades, campos, etc.
        private double n1;
        private double n2;

        // Constructor.
        public cldivisión(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        // Metodos.
        public double Dividir()
        {
            return n1 / n2;
        }
    }
}
