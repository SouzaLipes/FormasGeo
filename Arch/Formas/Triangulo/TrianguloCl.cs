using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria.Formas.Triangulo
{
    sealed class TrianguloCl : FormasCl
    {
        public float Comprimento_Base { get;set; }
        public float Comprimento_Altura { get; set; }

        public TrianguloCl(float Comprimento_base, float Comprimento_Altura) 
        {
            this.Comprimento_Base = Comprimento_base;
            this.Comprimento_Altura = Comprimento_Altura;
        }

        public override float CalcularArea()
        {
            return (Comprimento_Base * Comprimento_Altura) /2;
        }

        public override float CalcularPerimetro()
        {
            return (float)(3 * Comprimento_Base);
        }

    }
}
