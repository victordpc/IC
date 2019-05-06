using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public class Lloyd:Aprendizaje
    {
        public float tolerancia { get; set; }
        public int iteraciones { get; set; }
        public float aprendizaje { get; set; }

        public override string Clasificar(Muestra muestraComprobar)
        {
            throw new NotImplementedException();
        }
         
        public override void Entrenar()
        {
                CentrosIniciales();
        throw new NotImplementedException();
        }
    }
}
