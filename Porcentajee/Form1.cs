using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porcentajee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txConvertir_Click(object sender, EventArgs e)
        {
            double x, d;

            x = double.Parse(textBox1.Text);

            d = 0.2 * x;

            MessageBox.Show("El 20% de " + x + " es: " + d);
        }

        private void txConvertir_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // validacion.SoloNumeros(e);
            if (e.KeyChar == 13)
            {
                double x, d;

                x = double.Parse(textBox1.Text);

                d = 0.2 * x;

                MessageBox.Show("El 20% de " + x + " es: " + d);
            }
        }
    }
}
