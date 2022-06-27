using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public enum Op
    {
        NoDef = 0,
        Suma = 1,
        Resta = 2,
        Multiplicación = 3,
        División = 4
    }
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        Op operacion = Op.NoDef;
        public Form1()
        {
            InitializeComponent();
        }

        private void Numeros(string numero)
        {
            if (txtResultado.Text == "0" && txtResultado.Text != null)
            {
                txtResultado.Text = numero;
            }
            else
            {
                txtResultado.Text += numero;
            }
        }

        private double Operaciones()
        {
            double resultado = 0;

            switch (operacion)
            {
                case Op.Suma:
                    resultado = num1 + num2;
                    break;
                case Op.Resta:
                    resultado = num1 - num2;
                    break;
                case Op.Multiplicación:
                    resultado = num1 * num2;
                    break;
                case Op.División:
                    if (num2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }

            return resultado;
        }

        private void EjecutarOperacion(string operador)
        {
            num1 = Convert.ToDouble(txtResultado.Text);
            lblresumen.Text = txtResultado.Text + operador;
            txtResultado.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Numeros("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Numeros("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Numeros("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Numeros("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Numeros("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Numeros("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Numeros("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Numeros("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Numeros("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Numeros("9");
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = Op.Suma;
            EjecutarOperacion("+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = Op.Resta;
            EjecutarOperacion("-");
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion = Op.Multiplicación;
            EjecutarOperacion("*");
        }

        private void btnDivivir_Click(object sender, EventArgs e)
        {
            operacion = Op.División;
            EjecutarOperacion("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (num2 == 0)
            {
                num2 = Convert.ToDouble(txtResultado.Text);
                lblresumen.Text += num2 + "=";
                double result = Operaciones();
                num1 = 0; num2 = 0;
                txtResultado.Text = Convert.ToString(result);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            lblresumen.Text = "";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Contains("."))
            {
                return;
            }

            txtResultado.Text += (".");
        }
    }
}
