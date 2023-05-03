using Geometria.Formas.Triangulo;
using Geometria.FormasG.RetanguloR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometria.FormasG.TrianguloT
{
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }

        private void txt_altura_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_area_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_ResultadoP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Lado_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Calculo_Click(object sender, EventArgs e)
        {
            float basee = float.Parse(txt_Lado.Text);
            float altura = float.Parse(txt_altura.Text);

            TrianguloCl triangulo = new TrianguloCl(basee, altura);

            txt_area.Text = triangulo.CalcularArea().ToString();
            txt_ResultadoP.Text = triangulo.CalcularPerimetro().ToString();

        }
    }
}
