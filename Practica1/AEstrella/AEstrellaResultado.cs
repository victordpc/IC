using System.Collections.Generic;

namespace Algoritmia
{
    public class AEstrellaResultado
    {
        public AEstrellaResultado(Punto[,] mapa)
        {
            Mapa = mapa;
        }

        public AEstrellaResultado(Punto[,] mapa, double coste) : this(mapa)
        {
            Coste = coste;
        }

        public AEstrellaResultado(List<Coordenada> camino, double coste)
        {
            Camino = camino;
            Coste = coste;
        }

        public AEstrellaResultado(Punto[,] mapa, List<Coordenada> camino, double coste):this(mapa,coste)
        {
            Camino = camino;
        }

        public Punto[,] Mapa { get; internal set; }

        public List<Coordenada> Camino { get; internal set; }

        public double Coste { get; internal set; }
    }
}