using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resta__Constructor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia de la clase clresta y se le pasan al constructor los parametros tomados de la texBox1 y texBox2.
            clresta oresta = new clresta(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            // Se le asigna a la textBox3 el resultado que se le aplica al objeto oresta con el metodo Resta y se pasa a tipo string.
            textBox3.Text = oresta.Resta().ToString();
        }
    }
}
