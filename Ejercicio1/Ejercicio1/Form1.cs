using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(Numero1TextBox1.Text);
            imparopar(numero);
            negativoopositivo(numero);
        }

        private void imparopar (int numero) 
        {
            int sobrante = numero % 2;
            if (sobrante == 0)
            {
                MessageBox.Show("El numero es Par", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El numero es Impar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void negativoopositivo(int numero)
        {
            if (numero >= 1) 
            {
                MessageBox.Show("El numero es positivo","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El numero es Negativo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
}


