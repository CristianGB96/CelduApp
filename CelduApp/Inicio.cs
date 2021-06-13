using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelduApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generar Texto
            decimal repetir = numericUpDown1.Value;
            string nombre = textBox1.Text;
            string imprime = "";

            for(int i = 1; i <= repetir; i++)
            {
                imprime += nombre + i.ToString()+"\n";
            }
            richTextBox1.Text = imprime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiar campos
            numericUpDown1.Value = 1;
            textBox1.Text = "";
            richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Copiar al portapapeles
            Clipboard.Clear();
            if (richTextBox1.Text.Length != 0)
            {
                Clipboard.SetText(richTextBox1.Text); 
            }
        }
    }
}
