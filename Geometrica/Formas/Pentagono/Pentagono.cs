using Geometria.Formas.Pentagono;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometria.FormasG.PentagonoP
{
    public partial class Pentagono : Form
    {
        public Pentagono()
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

        private void txt_Apotema_TextChanged(object sender, EventArgs e)
        {
        }

        private float CalculaApotema(float valor)
        {
            float area = float.Parse(txt_area.Text);
            return (float)((5 / 2 * valor) / area);
        }

        private void btn_Calculo_Click(object sender, EventArgs e)
        {
            float valor = float.Parse(txt_Lado.Text);

            PentagonoCl penta = new PentagonoCl(valor);

            txt_ResultadoP.Text = penta.CalcularPerimetro().ToString();
            txt_area.Text = penta.CalcularArea().ToString();
            txt_Apotema.Text = CalculaApotema(valor).ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}
