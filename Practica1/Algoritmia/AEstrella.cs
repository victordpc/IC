using Priority_Queue;
using System;
using System.Collections.Generic;

namespace Algoritmia
{
    public static class Algoritmia
    {

        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, Punto[,] mapa)
        {
            AEstrella aEstrella = new AEstrella(inicio, meta, mapa);
            return aEstrella.Algoritmo();
        }

        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, Punto[,] mapa, params Coordenada[] waypoints)
        {
            AEstrellaResultado resultado = new AEstrellaResultado(new List<Coordenada>(), 0);
            Coordenada[] puntos = new Coordenada[waypoints.Length + 2];

            int i = 0;
            puntos[i++] = inicio;
            for (; i <= waypoints.Length; i++)
            {
                puntos[i] = waypoints[i - 1];
            }
            puntos[i] = meta;

            i = 1;
            for (; i < puntos.Length; i++)
            {
                AEstrella aEstrella = new AEstrella(puntos[i - 1], puntos[i], mapa);
                AEstrellaResultado parcial = aEstrella.Algoritmo();
                if (parcial.Camino==null)
                {
                    return new AEstrellaResultado(mapa, null, 0.0);
                }
                resultado.Coste += parcial.Coste;
                resultado.Camino.AddRange(parcial.Camino);
                aEstrella.LimpiarListas();
            }
            return resultado;
        }

    }

    internal class AEstrella : IAEstrella
    {
        internal AEstrella(Coordenada inicio, Coordenada meta, Punto[,] mapa)
        {
            Inicio = inicio;
            Meta = meta;
            Mapa = mapa;
            Abierta = new FastPriorityQueue<Punto>(mapa.Length);
            Waypoints = null;
        }


        private Coordenada Inicio { get; set; }

        private Coordenada Meta { get; set; }

        private Punto[,] Mapa { get; set; }

        private FastPriorityQueue<Punto> Abierta { get; set; }

        private Coordenada[] Waypoints { get; set; }

        public AEstrellaResultado Algoritmo()
        {
            AEstrellaResultado resultado = null;
            // Calculamos la heuristica entre el inicio y el final
            Mapa[Inicio.X, Inicio.Y].H = Calculo.Distancia(Inicio, Meta);
            // Agregamos el nodo inicio a la lista abierta
            Mapa[Inicio.X, Inicio.Y].Abierto = true;
            Abierta.Enqueue(Mapa[Inicio.X, Inicio.Y], Mapa[Inicio.X, Inicio.Y].F);

            // Ejecutamos el algoritmo
            Punto punto = CalculoAlgoritmo();

            // Procesamos el resultado
            resultado = ProcesarResultado(punto);
            return resultado;
        }

        private AEstrellaResultado ProcesarResultado(Punto resultadoAlgoritmo)
        {
            AEstrellaResultado resultado;
            if (resultadoAlgoritmo == null)
            {
                resultado = new AEstrellaResultado(Mapa, null, 0.0);
            }
            else
            {
                resultado = new AEstrellaResultado(Mapa, new List<Coordenada>(), resultadoAlgoritmo.F);
                TratarCaminoResultado(resultadoAlgoritmo, resultado);
            }
            return resultado;
        }

        private static void TratarCaminoResultado(Punto resultadoAlgoritmo, AEstrellaResultado resultado)
        {
            Punto actual = resultadoAlgoritmo;
            while (actual != null)
            {
                resultado.Camino.Add(actual.GetCoordenada());
                actual = actual.Padre;
            }
            resultado.Camino.Reverse();

        }

        private Punto CalculoAlgoritmo()
        {
            Punto resultado;

            if (Abierta.Count == 0)
                return null;

            Punto actual = Abierta.Dequeue();

            //Cerramos el nodo
            actual.Abierto = false;

            if (actual.GetCoordenada().Equals(Meta))
                resultado = Mapa[Meta.X, Meta.Y];
            else
            {

                // Expansion del punto actual
                for (int i = -1; i <= 1; i++)
                {
                    if (actual.X + i >= 0 && actual.X + i < Mapa.GetLength(0))
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (actual.Y + j >= 0 && actual.Y + j < Mapa.GetLength(1))
                            {
                                if (Mapa[actual.X + i, actual.Y + j].Permitido)
                                {
                                    // Calculamos los costes de acceder
                                    double coste = Calculo.Distancia(Mapa[actual.X, actual.Y], Mapa[actual.X + i, actual.Y + j]);

                                    if (Mapa[actual.X + i, actual.Y + j].Abierto == true)// Actualizamos la lista abierta
                                    {
                                        if (Mapa[actual.X + i, actual.Y + j].G > Mapa[actual.X, actual.Y].G + coste) // Si el coste es menor
                                        {
                                            Mapa[actual.X + i, actual.Y + j].G = Mapa[actual.X, actual.Y].G + coste;
                                            Mapa[actual.X + i, actual.Y + j].Padre = Mapa[actual.X, actual.Y];
                                            Abierta.UpdatePriority(Mapa[actual.X + i, actual.Y + j], Mapa[actual.X + i, actual.Y + j].F);
                                        }
                                    }
                                    else if (Mapa[actual.X + i, actual.Y + j].Abierto == null) // Agregamos a la lista abierta
                                    {
                                        Mapa[actual.X + i, actual.Y + j].Abierto = true;
                                        Mapa[actual.X + i, actual.Y + j].G = Mapa[actual.X, actual.Y].G + coste;
                                        Mapa[actual.X + i, actual.Y + j].H = Calculo.Distancia(Mapa[actual.X + i, actual.Y + j], Meta);
                                        Mapa[actual.X + i, actual.Y + j].Padre = Mapa[actual.X, actual.Y];

                                        Abierta.Enqueue(Mapa[actual.X + i, actual.Y + j], Mapa[actual.X + i, actual.Y + j].F);
                                    }
                                }
                            }
                        }
                    }
                }
                resultado = CalculoAlgoritmo();
            }
            return resultado;
        }

        internal void LimpiarListas()
        {
            Abierta.Clear();
            foreach (Punto item in Mapa)
            {
                Abierta.ResetNode(item);
                if (item.Abierto == true)
                {
                    item.Abierto = null;
                }
            }
        }
    }
}
