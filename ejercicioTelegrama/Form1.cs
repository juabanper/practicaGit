using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama; // JCBP2425
            int numPalabras = 0; // JCBP2425
            double coste; // JCBP2425

            //Leo el telegrama // JCBP2425
            textoTelegrama = txtTelegrama.Text;

            string[] palabras = textoTelegrama.Split(' '); // Separa las palabras y las introduce en una estructura - JJBP2425

            //Obtengo el número de palabras que forma el telegrama // JCBP2425
            numPalabras = palabras.Length; // 

            //Si el telegrama es ordinario // JCBP2425
            if (radioBtnOrdinario.Checked)
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras -10);
                }
            }
            else
            //Si el telegrama es urgente // JCBP2425
            {
                if (radioBtnUrgente.Checked)
                {
                    if (numPalabras <= 10)
                    {
                        coste = 5;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
