using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Formas.Pentagono
{
    sealed class PentagonoCl : FormasCl
    {
        public float Comprimento_lado { get; set; }

        public PentagonoCl(float comprimento_lado)
        {
            this.Comprimento_lado = comprimento_lado;
        }

        public override float CalcularArea()
        {
            return (float)(0.25 * (Math.Sqrt(5*(5+2*Math.Sqrt(5)*Math.Pow(Comprimento_lado, 2)))));
        }

        public override float CalcularPerimetro()
        {
            return (float)(5 * Comprimento_lado);
        }
    }
}
