using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmia
{
    public class Kmedias:Aprendizaje
    {
        public double tolerancia { get; set; }
        public double pesoExponencialB { get; set; }

        private int iteraciones=0;

        public override string Clasificar(Muestra muestraComprobar)
        {
            List<double> distancias = new List<double>();

            CalcularPertenenciaClases(muestraComprobar, distancias);

            string resultado = "Pertenencias: " + Environment.NewLine;

            for (int i = 0; i < Datos.Count; i++)
            {
                resultado += "Clase " + Datos[i].Nombre.ToString() + ": ";
                resultado += distancias[i].ToString("F");
                resultado += Environment.NewLine;
            }

            return resultado;
        }

        private void CalcularPertenenciaClases(Muestra muestraComprobar, List<double> distancias)
        {
            foreach (Muestra item in Centros)
            {
                distancias.Add(this.DistanciaCuadrado(item, muestraComprobar));
            }

            for (int i = 0; i < distancias.Count; i++)
            {
                distancias[i] = Math.Pow(1 / distancias[i], (1 / (pesoExponencialB - 1)));
            }

            double suma = distancias.Sum();

            for (int i = 0; i < distancias.Count; i++)
            {
                distancias[i] = distancias[i] / suma;
            }
        }

        public override void Entrenar()
        {
            CentrosIniciales();

            int numeroMuestras = Muestras.Count;
            int numeroClases = this.Datos.Count();
            int dimensionMuestra = Muestras.First().Medidas.Count();
            bool continuar = true;

            while (continuar)
            {
                //Crear matriz pertenencia
                double[][] pertenencia = new double[numeroClases][];
                for (int i = 0; i < numeroClases; i++)
                     pertenencia[i] = new double[numeroMuestras];
 
                //Calculamos matriz pertenencia
                for (int j = 0; j < numeroMuestras; j++)
                {
                    List<double> distancias = new List<double>();
                    CalcularPertenenciaClases(Muestras[j], distancias);

                    for (int i = 0; i < numeroClases; i++)
                        pertenencia[i][j] = distancias[i];

                }

                //Calculamos los nuevos centros para cada clase
                for (int i = 0; i < numeroClases; i++)
                {
                    //Calculamos la suma para el divisor
                    double sumaClase = pertenencia[i].Sum(f => Math.Pow(f, pesoExponencialB));
                    //double sumaClase = pertenencia[i].Sum();

                    //Calculamos la suma para el dividendo
                    double[][] sumaParcialDividendo = new double[dimensionMuestra][];
                    for (int l = 0; l < dimensionMuestra; l++)
                        sumaParcialDividendo[l] = new double[numeroMuestras];

                    for (int j = 0; j < numeroMuestras; j++)
                        for (int k = 0; k < dimensionMuestra; k++)
                            sumaParcialDividendo[k][j] += Muestras[j].Medidas[k] * Math.Pow( pertenencia[i][j],pesoExponencialB);

                    //Actualizamos los valores del centro de cada clase
                    for (int m = 0; m < dimensionMuestra; m++)
                    {
                       Datos[i].Centro.Medidas[m] = sumaParcialDividendo[m].Sum(f=>f) / sumaClase;
                    }


                }
                continuar = SeguirCalculando();
            }

            //Una vez que hemos acabado el entrenamiento actualizamos los centros
            for (int i = 0; i < Centros.Count; i++)
            {
                for (int j = 0; j < Centros[i].Medidas.Count; j++)
                {
                    Centros[i].Medidas[j] = Datos[i].Centro.Medidas[j];
                }
            }
        }

        private bool SeguirCalculando()
        {
            //Condicion de seguridad, si llevamos mas de 10000 iteraciones paramos de entrenar
            if (++iteraciones>=10000)
                 return false;

            //Comparamos la diferencia entre los centros iniciales y finales
            //si es menor que el epsilon marcado paramos en caso contrario
            //seguimos entrenando
            bool resultado = false;
 
            for (int i = 0; i < Centros.Count; i++)
                 if (this.Distancia(Centros[i], Datos[i].Centro) > tolerancia)
                    resultado= true;
 
 
            return resultado;
        }

     }
}
