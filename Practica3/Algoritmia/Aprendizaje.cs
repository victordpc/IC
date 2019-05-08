using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public abstract class Aprendizaje
    {
        public List<Muestra> Centros { get; set; }
        public List<Clase> Datos { get; set; }
        public List<Muestra> Muestras { get; set; }

        //public string Clasificar(Muestra muestraComprobar)
        //{
        //    int mejorPertenencia = 0;
        //    double acumulado = 0;
        //    double menorDistancia = double.MaxValue;

        //    for (int i = 0; i < Datos.Count; i++)
        //    {
        //        for (int j = 0; j < muestraComprobar.Medidas.Count; j++)
        //        {
        //            acumulado += Math.Pow(Datos[i].Centro.Medidas[j] - muestraComprobar.Medidas[j], 2);
        //        }

        //        acumulado = Math.Sqrt(acumulado);

        //        if (menorDistancia > acumulado)
        //        {
        //            mejorPertenencia = i;
        //            menorDistancia = acumulado;
        //        }

        //        acumulado = 0;
        //    }

        //    return Datos[mejorPertenencia].Nombre;
        //}

        public abstract string Clasificar(Muestra muestraComprobar);

        public abstract void Entrenar();

        protected void CentrosIniciales()
        {
            for (int i = 0; i < Centros.Count; i++)
                foreach (var item in Centros[i].Medidas)
                    Datos[i].Centro.Medidas.Add(item);
        }

        protected double DistanciaCuadrado(Muestra origen, Muestra destino)
        {
            double resultado = 0;

            if (origen.Medidas.Count == destino.Medidas.Count)
            {
                for (int i = 0; i < origen.Medidas.Count; i++)
                {
                    resultado += Math.Pow(origen.Medidas[i] - destino.Medidas[i], 2);
                }
                resultado = Math.Sqrt(resultado);
            }

            return resultado;
        }

        protected double Distancia(Muestra origen, Muestra destino)
        {
            double resultado = 0;

            if (origen.Medidas.Count == destino.Medidas.Count)
            {
                resultado = DistanciaCuadrado(origen, destino);
                resultado = Math.Sqrt(resultado);
            }

            return resultado;
        }

    }
}