using Geometria.Formas.Quadrado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometria.FormasG.QuadradoQ
{
    public partial class Quadrado : Form
    {
        public Quadrado()
        {
            InitializeComponent();
        }

        private void txt_Lado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ResultadoP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_area_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Calculo_Click(object sender, EventArgs e)
        {
            float valor = float.Parse(txt_Lado.Text);

            QuadradoCl quadrado = new QuadradoCl(valor);

            txt_area.Text = quadrado.CalcularArea().ToString();
            txt_ResultadoP.Text = quadrado.CalcularPerimetro().ToString();

        }
    }
}
