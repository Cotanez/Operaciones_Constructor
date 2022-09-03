using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora__Constructor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia de la clase cloperaciones y se le pasan al constructor los parametros tomados de la texBox1 y texBox2.
            cloperaciones osuma = new cloperaciones(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            // Se le asigna a la textBox3 el resultado que se le aplica al objeto osuma con el metodo Sumar y se pasa a tipo string.
            textBox3.Text = osuma.Sumar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Instancia de la clase cloperaciones y se le pasan al constructor los parametros tomados de la texBox1 y texBox2.
            cloperaciones oresta = new cloperaciones(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            // Se le asigna a la textBox3 el resultado que se le aplica al objeto oresta con el metodo Restar y se pasa a tipo string.
            textBox3.Text = oresta.Restar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cloperaciones omul = new cloperaciones(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            textBox3.Text = omul.Multiplicar().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cloperaciones odiv = new cloperaciones(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            textBox3.Text = odiv.Dividir().ToString();
        }
    }
}
