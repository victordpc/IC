using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public class Clase
    {
        public Clase()
        {
             Centro = new Muestra();
        }

        public string Nombre { get; set; }

        public Muestra Centro { get; set; }
        
         public override string ToString()
        {
            string resultado = "";
            resultado += Nombre + "; ";
            resultado += "Centro =" + (Centro.Medidas.Count() == 0 ? "" : Centro.ToString()) + "; ";
            return resultado;
        }
    }
}
