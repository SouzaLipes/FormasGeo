using Geometria.FormasG.CirculoC;
using Geometria.FormasG.HexagonoH;
using Geometria.FormasG.OctagonoO;
using Geometria.FormasG.PentagonoP;
using Geometria.FormasG.QuadradoQ;
using Geometria.FormasG.RetanguloR;
using Geometria.FormasG.TrianguloT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrica.Formas
{
    public partial class Formass : Form
    {
        public Formass()
        {
            InitializeComponent();
        }

        private void Formas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Hexagono_Click(object sender, EventArgs e)
        {
            Hexagono forma = new Hexagono();
            forma.ShowDialog();
        }

        private void btn_Circulo_Click(object sender, EventArgs e)
        {
            Circulo forma = new Circulo();
            forma.ShowDialog();
        }

        private void btn_Octagono_Click(object sender, EventArgs e)
        {
            Octagono forma = new Octagono();
            forma.ShowDialog();
        }

        private void btn_Pentagono_Click(object sender, EventArgs e)
        {
            Pentagono forma = new Pentagono();
            forma.ShowDialog();
        }

        private void btn_Triangulo_Click(object sender, EventArgs e)
        {
            Triangulo forma = new Triangulo();
            forma.ShowDialog();
        }

        private void btn_Retangulo_Click(object sender, EventArgs e)
        {
            Retangulo forma = new Retangulo();
            forma.ShowDialog();
        }

        private void btn_Quadrado_Click(object sender, EventArgs e)
        {
            Quadrado forma = new Quadrado();
            forma.ShowDialog();
        }
    }
}
