using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geometria.Formas.Circulo
{
    sealed class CirculoCl : FormasCl
    {

        public float raio { get; set; }

        public CirculoCl(float raio)
        {
            this.raio = raio;
        }
        public override float CalcularArea()
        {
            return(float)(Math.PI * Math.Pow(raio, 2));
        }

        public override float CalcularPerimetro()
        {
            return (float)(Math.PI * 2 + raio);
        }
    }
}
