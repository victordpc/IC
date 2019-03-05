using System.Collections.Generic;

namespace Algoritmia
{
    /// <summary>
    /// Clase para gestionar el uso de los algoritmos implementados
    /// </summary>
    public static class Algoritmia
    {

        /// <summary>
        /// Calcula con el algoritmo A* el camino entre el inicio y la meta en el mapa proporcionado
        /// </summary>
        /// <param name="inicio">Coordenada de inicio</param>
        /// <param name="meta">Coordenada de llegada</param>
        /// <param name="mapa">Mapa en el que se ajecuta el algoritmo</param>
        /// <returns>Objeto Resultado con el camino y el coste.</returns>
        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, Punto[,] mapa)
        {
            AEstrella aEstrella = new AEstrella(inicio, meta, true,true, mapa);
            return aEstrella.Algoritmo();
        }

        /// <summary>
        /// Calcula con el algoritmo A* el camino entre el inicio y la meta en el mapa proporcionado
        /// </summary>
        /// <param name="inicio">Coordenada de inicio</param>
        /// <param name="meta">Coordenada de llegada</param>
        /// <param name="MovimientoDiagonal">Indica si se permite el movimiento lateral</param>
        /// <param name="mapa">Mapa en el que se ajecuta el algoritmo</param>
        /// <returns>Objeto Resultado con el camino y el coste.</returns>
        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, bool MovimientoDiagonal, Punto[,] mapa)
        {
            AEstrella aEstrella = new AEstrella(inicio, meta, MovimientoDiagonal, true, mapa);
            return aEstrella.Algoritmo();
        }
    
        /// <summary>
        /// Calcula con el algoritmo A* el camino entre el inicio y la meta en el mapa proporcionado
        /// </summary>
        /// <param name="inicio">Coordenada de inicio</param>
        /// <param name="meta">Coordenada de llegada</param>
        /// <param name="MovimientoDiagonal">Indica si se permite el movimiento lateral</param>
        /// <param name="mapa">Mapa en el que se ajecuta el algoritmo</param>
        /// <returns>Objeto Resultado con el camino y el coste.</returns>
        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, bool MovimientoDiagonal,bool MovimientoOrtogonal, Punto[,] mapa)
        {
            AEstrella aEstrella = new AEstrella(inicio, meta, MovimientoDiagonal, MovimientoOrtogonal, mapa);
            return aEstrella.Algoritmo();
        }
        
        /// <summary>
        /// Calcula con el algoritmo A* el camino entre el inicio y la meta en el mapa proporcionado
        /// </summary>
        /// <param name="inicio">Coordenada de inicio</param>
        /// <param name="meta">Coordenada de llegada</param>
        /// <param name="MovimientoDiagonal">Indica si se permite el movimiento lateral</param>
        /// <param name="mapa">Mapa en el que se ajecuta el algoritmo</param>
        /// <param name="waypoints">Puntos intermedios por los que hay que pasar en orden</param>
        /// <returns>Objeto Resultado con el camino y el coste.</returns>
        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, bool MovimientoDiagonal, Punto[,] mapa, params Coordenada[] waypoints)
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
                AEstrella aEstrella = new AEstrella(puntos[i - 1], puntos[i], MovimientoDiagonal,true, mapa);
                AEstrellaResultado parcial = aEstrella.Algoritmo();
                if (parcial.Camino == null)
                {
                    return new AEstrellaResultado(mapa, null, 0.0);
                }
                resultado.Coste += parcial.Coste;
                resultado.Camino.AddRange(parcial.Camino);
                aEstrella.LimpiarListas();
            }
            return resultado;
        }

        /// <summary>
        /// Calcula con el algoritmo A* el camino entre el inicio y la meta en el mapa proporcionado
        /// </summary>
        /// <param name="inicio">Coordenada de inicio</param>
        /// <param name="meta">Coordenada de llegada</param>
        /// <param name="MovimientoDiagonal">Indica si se permite el movimiento lateral</param>
        /// <param name="mapa">Mapa en el que se ajecuta el algoritmo</param>
        /// <param name="waypoints">Puntos intermedios por los que hay que pasar en orden</param>
        /// <returns>Objeto Resultado con el camino y el coste.</returns>
        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, bool MovimientoDiagonal,bool MovimientoOrtogonal, Punto[,] mapa, params Coordenada[] waypoints)
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
                AEstrella aEstrella = new AEstrella(puntos[i - 1], puntos[i], MovimientoDiagonal, MovimientoOrtogonal, mapa);
                AEstrellaResultado parcial = aEstrella.Algoritmo();
                if (parcial.Camino == null)
                {
                    return new AEstrellaResultado(mapa, null, 0.0);
                }
                resultado.Coste += parcial.Coste;
                resultado.Camino.AddRange(parcial.Camino);
                aEstrella.LimpiarListas();
            }
            return resultado;
        }


        /// <summary>
        /// Calcula con el algoritmo A* el camino entre el inicio y la meta en el mapa proporcionado
        /// </summary>
        /// <param name="inicio">Coordenada de inicio</param>
        /// <param name="meta">Coordenada de llegada</param>
        /// <param name="MovimientoDiagonal">Indica si se permite el movimiento lateral</param>
        /// <param name="mapa">Mapa en el que se ajecuta el algoritmo</param>
        /// <param name="waypoints">Puntos intermedios por los que hay que pasar en orden</param>
        /// <returns>Objeto Resultado con el camino y el coste.</returns>
        public static AEstrellaResultado CalculoAEstrella(Coordenada inicio, Coordenada meta, bool MovimientoDiagonal, bool MovimientoOrtogonal,bool Nadar, bool Escalar, Punto[,] mapa, params Coordenada[] waypoints)
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
                AEstrella aEstrella = new AEstrella(puntos[i - 1], puntos[i], MovimientoDiagonal, MovimientoOrtogonal, mapa);
                AEstrellaResultado parcial = aEstrella.Algoritmo();
                if (parcial.Camino == null)
                {
                    return new AEstrellaResultado(mapa, null, 0.0);
                }
                resultado.Coste += parcial.Coste;
                resultado.Camino.AddRange(parcial.Camino);
                aEstrella.LimpiarListas();
            }
            return resultado;
        }

        /// <summary>
        /// Calcula con el algoritmo A* el camino entre el inicio y la meta en el mapa proporcionado
        /// </summary>
        /// <param name="inicio">Coordenada de inicio</param>
        /// <param name="meta">Coordenada de llegada</param>
        /// <param name="mapa">Mapa en el que se ajecuta el algoritmo</param>
        /// <param name="waypoints">Puntos intermedios por los que hay que pasar en orden</param>
        /// <returns>Objeto Resultado con el camino y el coste.</returns>
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
                AEstrella aEstrella = new AEstrella(puntos[i - 1], puntos[i], true,true, mapa);
                AEstrellaResultado parcial = aEstrella.Algoritmo();
                if (parcial.Camino == null)
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
}
