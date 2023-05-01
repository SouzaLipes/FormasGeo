using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria.FormasG.OctagonoO;

namespace Geometria.Formas.Octagono
{
    sealed class OctagonoCl : FormasCl
    {
        public float Comprimento_lado { get; set; }

        public OctagonoCl(float comprimento_lado)
        {
            this.Comprimento_lado = comprimento_lado;
        }

        public override float CalcularArea()
        {
            return (float)(2 * (1 + Math.Sqrt(2))* Math.Pow(Comprimento_lado, 2));
        }

        public override float CalcularPerimetro()
        {
            return (float)(8 * Comprimento_lado);
        }
    }
}
