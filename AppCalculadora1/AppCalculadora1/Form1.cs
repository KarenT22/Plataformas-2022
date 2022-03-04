using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora1
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            float num1, num2, suma;

            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);

            suma = num1 + num2;
            txtResultado.Text = suma.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, resta;

            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);

            resta = num1 - num2;
            txtResultado.Text = resta.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            float num1, num2, multiplicacion;

            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);

            multiplicacion = num1 * num2;
            txtResultado.Text = multiplicacion.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float num1, num2, division;

            num1 = float.Parse(txtNum1.Text);
            num2 = float.Parse(txtNum2.Text);

            division = num1 / num2;
            txtResultado.Text = division.ToString();
        }

        private void btnPotenciaN_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            float num1, potencia;

            num1 = float.Parse(txtNum1.Text);
            

            potencia = num1 * num1;
            txtResultado.Text = potencia.ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }

        private void btnPotenciaN_Click_1(object sender, EventArgs e)
        {
            int num1, num2, potencian = 1, contador;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            for (contador = 1; contador <= num2; contador++)
            {
                potencian = potencian * num1;
            }

            txtResultado.Text = potencian.ToString();

        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            double num, factorial=1;

            num = double.Parse(txtNum1.Text);
            
            while (num != 0)
            {
                factorial = factorial * num; num--;
            }

            txtResultado.Text = factorial.ToString();
        }
    }
}
