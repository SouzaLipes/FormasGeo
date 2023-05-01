using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Formas.Quadrado
{
    sealed class QuadradoCl : FormasCl
    {
        public float Comprimento_lado { get; set; }

        public QuadradoCl(float Comprimento_lado)
        {
            this.Comprimento_lado = Comprimento_lado;
        }

        public override float CalcularArea()
        {
            return Comprimento_lado * Comprimento_lado;
        }

        public override float CalcularPerimetro()
        {
            return (float)(4 * Comprimento_lado);
        }

    }
}
