using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Calcularbutton1_Click(object sender, EventArgs e)
        {

            decimal num1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal num3 = Convert.ToDecimal(Nota3TextBox.Text);
            decimal num4 = Convert.ToDecimal(Nota4TextBox.Text);

            decimal total = await promedioAsync(num1, num2, num3, num4);

            MessageBox.Show($"El promedio es: {total}","Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private  async Task<decimal> promedioAsync(decimal n1 , decimal n2 , decimal n3 , decimal n4)
        {

            decimal promedio = await Task.Run(() => 
           {

               return (n1 + n2 + n3 + n4)/4;
           } );

            return promedio;
        
        }

        private void TotalTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
