using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadoraGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbArea.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double area = Math.PI * Math.Pow(raio, 2);
                lbResultado.Text = "AREA = " + area.ToString("N3");
            }
            if (rbPerimetro.Checked == true)
            {
                double raio = Convert.ToDouble(txtRaio.Text);
                double perimetro = 2 * Math.PI * raio;
                lbResultado.Text = "PERIMETRO = "
                + perimetro.ToString("N3");
            }
            if (rbVolume.Checked == true)
            {
                 double raio = Convert.ToDouble(txtRaio.Text);
                 double volume = 3.0 / 4.0 * Math.PI * Math.Pow(raio, 3);
                 lbResultado.Text = "VOLUME ="
                     + volume.ToString("N3");
            }
            PlotarCirculo();
        }

        private void PlotarCirculo()
        {
            Graphics tela = pnDesenho.CreateGraphics();
            Pen caneta = new Pen(Color.Beige, 3);
            double raio = Convert.ToDouble(txtRaio.Text);
            tela.Clear(Color.Red);
            tela.DrawEllipse(caneta, 10, 10,(int)raio,(int)raio);
            tela.DrawRectangle(caneta, 10, 10, (int)raio, (int)raio);
        }
    }
}
