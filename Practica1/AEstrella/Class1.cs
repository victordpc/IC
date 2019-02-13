using System;

namespace AEstrella
{


    public sealed class Punto
    {
        public Punto(int x, int y, bool abierto = true)
        {
            X = x;
            Y = y;
            Abierto = abierto;
        }

        public Punto Padre { get; set; }

        /// <summary>
        /// Posición X en el plano
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Posicion Y en el plano
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        ///  Coste según la función heurística hasta la meta 
        /// </summary>
        public double H { get; set; }

        /// <summary>
        /// Coste desde el inicio
        /// </summary>
        public double G { get; set; }

        /// <summary>
        /// Suma de las funciones g y h
        /// </summary>
        public double F { get; private set; }

        /// <summary>
        /// Indica si el nodo ya ha sido tratado
        /// </summary>
        public bool Abierto { get; set; }
    }

    public static class Calculo
    {
        public static double Distancia(Punto A, Punto B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
    }

    public class AEstrella
    {
        private readonly PuntoComparer comparador;

        public AEstrella(Punto inicio, Punto meta, Punto[][] mapa, params Punto[] waypoints)
        {
            Inicio = inicio;
            Meta = meta;
            Mapa = mapa;
            Abierta = new PriorityQueue<Punto>(Int32.MaxValue, comparador);
        }

        public Punto Inicio { get; set; }

        public Punto Meta { get; set; }

        public Punto[][] Mapa { get; private set; }

        public PriorityQueue<Punto> Abierta { get; set; }
    
        public Punto algotitmo()
        {

        }

    }


    public class PuntoComparer : System.Collections.Generic.Comparer<Punto>
    {
        public override int Compare(Punto x, Punto y)
        {
            return x.F.CompareTo(y.F);
        }
    }
}
