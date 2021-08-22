using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double promedio = 0;

            nota1 = double.Parse(txtNota1.Text);
            nota2 = double.Parse(txtNota2.Text);
            nota3 = double.Parse(txtNota3.Text);

            promedio = (nota1 + nota2 + nota3)/3;

            txtPromedio.Text = promedio.ToString();


            if (promedio < 3)
            {
                txtEstado.Text = "reprovado";
            }
            else
            {
                txtEstado.Text = "aprovado";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
