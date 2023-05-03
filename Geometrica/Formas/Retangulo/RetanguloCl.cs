using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Formas.Retangulo
{
    sealed class RetanguloCl : FormasCl
    {
        public float Comprimento_Base { get; set; }
        public float Comprimento_Altura { get; set; }

        public RetanguloCl(float Comprimento_Base, float Comprimento_Altura)
        {
            this.Comprimento_Base = Comprimento_Base;
            this.Comprimento_Altura = Comprimento_Altura;
        }

        public override float CalcularArea()
        {
            return Comprimento_Base * Comprimento_Altura;
        }

        public override float CalcularPerimetro()
        {
            return (float)(2 * Comprimento_Base)+ (2 * Comprimento_Altura);
        }

    }
}
