using Priority_Queue;

namespace Algoritmia
{
    /// <summary>
    /// Clase que implementa el algoritmo A*
    /// </summary>
    internal class AEstrella : IAEstrella
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inicio">Punto de inicio</param>
        /// <param name="meta">Punto de fin</param>
        /// <param name="mapa">Mapa donde se ejecuta el algoritmo</param>
        internal AEstrella(Coordenada inicio, Coordenada meta, bool movimientoDiagonal, bool movimientoOrtogonal, bool nadar, bool escalar, Punto[,] mapa)
        {
            Inicio = inicio;
            Meta = meta;
            Mapa = mapa;
            Abierta = new FastPriorityQueue<Punto>(mapa.Length);
            Waypoints = null;
            Nadar = nadar;
            Escalar = escalar;
            MovimientoDiagonal = movimientoDiagonal;
            MovimientoOrtogonal = movimientoOrtogonal;
        }

        /// <summary>
        /// Llamada al algoritmo
        /// </summary>
        /// <returns>Objeto con el camino y el coste asociado</returns>
        public override AEstrellaResultado Algoritmo()
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

        /// <summary>
        /// Ejecución del algoritmo
        /// </summary>
        /// <returns>Punto del mapa al que se llega</returns>
        private Punto CalculoAlgoritmo()
        {
            Punto resultado = null;
            bool salir = false;

            while (!salir)
            {
                if (Abierta.Count == 0)
                    salir = true;
                else
                {
                    Punto actual = Abierta.Dequeue();

                    //Cerramos el nodo
                    actual.Abierto = false;

                    if (actual.GetCoordenada().Equals(Meta))
                    {
                        resultado = Mapa[Meta.X, Meta.Y];
                        salir = true;
                    }
                    else
                    {
                        // Expansion del punto actual
                        if (MovimientoDiagonal && MovimientoOrtogonal)
                            ExpansionConDiagonales(actual);
                        else
                        {
                            if (MovimientoOrtogonal)
                                ExpansionOrtogonal(actual);
                            if (MovimientoDiagonal)
                                ExpansionDiagonal(actual);
                        }
                    }
                }
            }

            return resultado;
        }

        private void ExpansionConDiagonales(Punto actual)
        {
            for (int i = -1; i <= 1; i++)
            {
                if (actual.X + i >= 0 && actual.X + i < Mapa.GetLength(0))
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (actual.Y + j >= 0 && actual.Y + j < Mapa.GetLength(1))
                        {
                            if (Mapa[actual.X + i, actual.Y + j].Permitido )
                            {
                                if (!(Mapa[actual.X + i, actual.Y + j].Valor == (float)Terreno.Agua && !Nadar))
                                    if (!(Mapa[actual.X + i, actual.Y + j].Valor == (float)Terreno.Roca && !Escalar))
                                    CostesYTratarNodos(actual, i, j);
                            }
                        }
                    }
                }
            }
        }

        private void ExpansionOrtogonal(Punto actual)
        {
            for (int i = -1; i <= 1; i += 2)
            {
                if (actual.X + i >= 0 && actual.X + i < Mapa.GetLength(0))
                {
                    if (Mapa[actual.X + i, actual.Y].Permitido)
                    {
                        CostesYTratarNodos(actual, i, 0);
                    }
                }
                if (actual.Y + i >= 0 && actual.Y + i < Mapa.GetLength(1))
                {
                    if (Mapa[actual.X, actual.Y + i].Permitido)
                    {
                        CostesYTratarNodos(actual, 0, i);
                    }
                }
            }
        }

        private void ExpansionDiagonal(Punto actual)
        {
            for (int i = -1; i <= 1; i += 2)
            {
                if ((actual.X + i >= 0 && actual.X + i < Mapa.GetLength(0)) && (actual.Y + i >= 0 && actual.Y + i < Mapa.GetLength(1)))
                {
                    if (Mapa[actual.X + i, actual.Y + i].Permitido)
                    {
                        CostesYTratarNodos(actual, 0+i, 0+i);
                    }
                }
                if ((actual.X + i >= 0 && actual.X + i < Mapa.GetLength(0)) && (actual.Y - i >= 0 && actual.Y - i < Mapa.GetLength(1)))
                {
                    if (Mapa[actual.X + i, actual.Y - i].Permitido)
                    {
                        CostesYTratarNodos(actual, 0+i, 0-i);
                    }
                }
            }
        }

        private void CostesYTratarNodos(Punto actual, int i, int j)
        {

            // Calculamos los costes de acceder
            double coste = Calculo.Distancia(Mapa[actual.X, actual.Y], Mapa[actual.X + i, actual.Y + j]);

            if (Mapa[actual.X + i, actual.Y + j].Abierto == true)// Actualizamos la lista abierta
            {
                ReorientacionEnlaces(actual, i, j, coste);
            }
            else if (Mapa[actual.X + i, actual.Y + j].Abierto == null) // Agregamos a la lista abierta
            {
                NodoAAbierta(actual, i, j, coste);
            }
        }

        /// <summary>
        /// Pasa el nodo a la lista abierta
        /// </summary>
        /// <param name="actual">Punto donde está el algoritmo</param>
        /// <param name="i">Incremento de la coordenada X</param>
        /// <param name="j">Incremento de la coordenada Y</param>
        /// <param name="coste">Coste del paso</param>
        private void NodoAAbierta(Punto actual, int i, int j, double coste)
        {
            Mapa[actual.X + i, actual.Y + j].Abierto = true;
            Mapa[actual.X + i, actual.Y + j].G = Mapa[actual.X, actual.Y].G + coste;
            Mapa[actual.X + i, actual.Y + j].H = Calculo.Distancia(Mapa[actual.X + i, actual.Y + j], Meta);
            Mapa[actual.X + i, actual.Y + j].Padre = Mapa[actual.X, actual.Y];

            Abierta.Enqueue(Mapa[actual.X + i, actual.Y + j], Mapa[actual.X + i, actual.Y + j].F);
        }

        /// <summary>
        /// Reorienta el enlace del nodo
        /// </summary>
        /// <param name="actual">Punto donde está el algoritmo</param>
        /// <param name="i">Incremento de la coordenada X</param>
        /// <param name="j">Incremento de la coordenada Y</param>
        /// <param name="coste">Coste del paso</param>
        private void ReorientacionEnlaces(Punto actual, int i, int j, double coste)
        {
            if (Mapa[actual.X + i, actual.Y + j].G > Mapa[actual.X, actual.Y].G + coste) // Si el coste es menor
            {
                Mapa[actual.X + i, actual.Y + j].G = Mapa[actual.X, actual.Y].G + coste;
                Mapa[actual.X + i, actual.Y + j].Padre = Mapa[actual.X, actual.Y];
                Abierta.UpdatePriority(Mapa[actual.X + i, actual.Y + j], Mapa[actual.X + i, actual.Y + j].F);
            }
        }
    }
}
