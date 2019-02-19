using Priority_Queue;
using System.Collections.Generic;

namespace Algoritmia
{
    public sealed class Punto : FastPriorityQueueNode
    {
        public Punto(int x, int y, bool? abierto = null)
        {
            X = x;
            Y = y;
            Abierto = abierto;
            G = 0;
            H = 0;
            Permitido = true;
            Valor = 0;
        }

        /// <summary>
        /// Punto del mapa precedente en la ruta
        /// </summary>
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
        public double F { get { return G + H + Valor; } }

        /// <summary>
        /// Coste añadido de la casilla
        /// </summary>
        public float Valor { get; set; }

        /// <summary>
        /// Indica si el nodo ya ha sido tratado
        /// </summary>
        public bool? Abierto { get; set; }

        /// <summary>
        /// Indica si está permitido usar el nodo
        /// </summary>
        public bool Permitido { get; set; }

        public override bool Equals(object obj)
        {
            var punto = obj as Punto;
            return punto != null &&
                   EqualityComparer<Punto>.Default.Equals(Padre, punto.Padre) &&
                   X == punto.X &&
                   Y == punto.Y &&
                   H == punto.H &&
                   G == punto.G &&
                   F == punto.F &&
                   Valor == punto.Valor &&
                   EqualityComparer<bool?>.Default.Equals(Abierto, punto.Abierto) &&
                   Permitido == punto.Permitido;
        }

        /// <summary>
        /// Devuelve la coordenada del punto en el mapa
        /// </summary>
        /// <returns>Objeto Coordenada con las transposición del punto en el mapa</returns>
        public Coordenada GetCoordenada()
        {
            return new Coordenada { X = X, Y = Y };
        }

        public override int GetHashCode()
        {
            var hashCode = -1773212324;
            hashCode = hashCode * -1521134295 + EqualityComparer<Punto>.Default.GetHashCode(Padre);
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + H.GetHashCode();
            hashCode = hashCode * -1521134295 + G.GetHashCode();
            hashCode = hashCode * -1521134295 + F.GetHashCode();
            hashCode = hashCode * -1521134295 + Valor.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(Abierto);
            hashCode = hashCode * -1521134295 + Permitido.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "X: " + X.ToString() +
                   " Y: " + Y.ToString() +
                   " H: " + H.ToString() +
                   " G: " + G.ToString() +
                   " F: " + F.ToString() +
                   " Valor: " + Valor.ToString() +
                   " Abierto: " + Abierto.ToString() +
                   " Permitido; " + Permitido.ToString();
            
        }
    }

}
