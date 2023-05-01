using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometria.Formas.Circulo;

namespace Geometria.FormasG.CirculoC
{
    sealed partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void txt_Raio_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_ResultadoP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Diametro_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_area_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Caculo_Click(object sender, EventArgs e)
        {
            float valor = float.Parse(txt_Raio.Text);

            CirculoCl circulo = new CirculoCl(valor);

            txt_ResultadoP.Text = circulo.CalcularPerimetro().ToString();

            txt_Diametro.Text = (valor * 2).ToString();

            txt_area.Text = circulo.CalcularArea().ToString();

        }
    }
}
