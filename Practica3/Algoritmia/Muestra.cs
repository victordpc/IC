using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public class Muestra
    {
        public Muestra()
        {
            Medidas = new List<double>();
        }
        public List<double> Medidas { get; set; }

        public override string ToString()
        {
            string resultado = "[";
            if (Medidas == null || Medidas.Count == 0)
                resultado = " ]";
            else
            {
                foreach (var item in Medidas)
                    resultado += item.ToString() + "; ";
                resultado = resultado.Substring(0, resultado.Length - 2) + "]";
            }
            return resultado;
        }
    }
}
