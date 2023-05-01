using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Formas.Hexagono
{
    sealed class HexagonoCL : FormasCl
    {
        public float Comprimento_lado { get; set; }

        public HexagonoCL(float comprimento_lado)
        {
            this.Comprimento_lado = comprimento_lado;
        }

        public override float CalcularArea()
        {
            return (float)(3 * Comprimento_lado *(Math.Sqrt(3)/2 * Comprimento_lado));
        }

        public override float CalcularPerimetro()
        {
            return (float)(6 *  Comprimento_lado);
        }
    }
}
