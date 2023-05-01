using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometria.FormasG.CirculoC;
using Geometria.FormasG.HexagonoH;
using Geometria.FormasG.OctagonoO;
using Geometria.FormasG.PentagonoP;
using Geometria.FormasG.QuadradoQ;
using Geometria.FormasG.RetanguloR;
using Geometria.FormasG.TrianguloT;

namespace Geometria.FormasG
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

        private void btn_Circulo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();
            circulo.ShowDialog();

        }

        private void btn_Octal_Click(object sender, EventArgs e)
        {
            Octagono octal = new Octagono();
            octal.ShowDialog();
        }

        private void btn_Hexagono_Click(object sender, EventArgs e)
        {
            Hexagono hexagono = new Hexagono();
            hexagono.ShowDialog();
        }

        private void btn_Quadrado_Click(object sender, EventArgs e)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.ShowDialog();
        }

        private void btn_Pentagono_Click(object sender, EventArgs e)
        {
            Pentagono penta = new Pentagono();
            penta.ShowDialog();
        }

        private void btn_triangulo_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.ShowDialog();
        }

        private void btn_Retangulo_Click(object sender, EventArgs e)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.ShowDialog();
        }
    }
}
