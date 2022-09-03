using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suma__Constructor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instancia de la clase clsuma y se le pasan al constructor los parametros tomados de la texBox1 y texBox2.
            clsuma osuma = new clsuma (int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            // Se le asigna a la textBox3 el resultado que se le aplica al objeto osuma con el metodo Suma y se pasa a tipo string.
            textBox3.Text = osuma.Suma().ToString();
        }
    }
}
