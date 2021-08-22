using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*Calcular el número de pulsaciones que debe tener una persona
             por cada 10 segundos de ejercicio aeróbico; la formula que
            se aplica cuando el
            sexo es femenino es:
            pulsaciones = (220 - edad) / 10
             si el sexo es masculino:
            pulsaciones = (210 - edad) / 10 
                */

            int pulsaciones = 0;
            int edad = 0;
            char sexo;

            sexo = char.Parse(txtsexo.Text);

            edad = int.Parse(txtEdad.Text);

            if (sexo.Equals("m") || sexo.Equals("M"))
            {
                pulsaciones = (210 - edad) / 10;

            }
            else
            {
                pulsaciones = (220 - edad) / 10;
            }

            txtPulsaciones.Text = pulsaciones.ToString();

        }
    }
}

          
    

