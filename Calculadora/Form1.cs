using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Form1 : Form {
       
        decimal valor1 = 0;
        decimal valor2 = 0;
        String operacao;

        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button6_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button13_Click(object sender, EventArgs e) {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "Mult";
            lblOperacao.Text = "*";
        }

        private void button12_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e) {
            txtResultado.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e) {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button16_Click(object sender, EventArgs e) {

            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "Soma";
            lblOperacao.Text = "+";

        }

        private void button18_Click(object sender, EventArgs e) {

            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if(operacao == "Soma") {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "Sub") {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "Mult") {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if(operacao == "Div") {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
            
        }

        private void button15_Click(object sender, EventArgs e) {

            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "Sub";
            lblOperacao.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e) {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "Div";
            lblOperacao.Text = "/";
        }

        private void button19_Click(object sender, EventArgs e) {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button20_Click(object sender, EventArgs e) {
            txtResultado.Text = "";
        }
    }
}
