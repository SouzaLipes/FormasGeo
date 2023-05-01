using Geometria.Formas.Octagono;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometria.FormasG.OctagonoO
{
    public partial class Octagono : Form
    {
        public Octagono()
        {
            InitializeComponent();
        }

        private void txt_Apotema_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void txt_ResultadoP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_area_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_Lado_TextChanged(object sender, EventArgs e)
        {
        }

        private float CalculaApotema(float valor)
        {
            return (float)(valor / 2 * 22.5);
        }
        private void btn_Calculo_Click(object sender, EventArgs e)
        {
            float valor = float.Parse(txt_Lado.Text);

            OctagonoCl hexagono = new OctagonoCl(valor);

            txt_ResultadoP.Text = hexagono.CalcularPerimetro().ToString();
            txt_area.Text = hexagono.CalcularArea().ToString();
            txt_Apotema.Text = CalculaApotema(valor).ToString();

        }
    }
}
