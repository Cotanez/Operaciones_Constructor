using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora__Constructor_
{
    internal class cloperaciones
    {
        // Propiedades, campos, etc.
        private int n1;
        private int n2;

        // Constructor.
        public cloperaciones(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        // Metodos.
        public int Sumar()
        {
            return n1 + n2;
        }
        public int Restar()
        {
            return n1 - n2;
        }
        public int Multiplicar()
        {
            return n1 * n2;
        }
        public double Dividir()
        {
            return (double)n1 / n2;
        }

    }
}
