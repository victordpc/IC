using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmia.Tests
{
    [TestClass()]
    public class AlgoritmiaTests
    {
        /// <summary>
        /// Prueba un mapa sencillo con movimiento libre
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, mapa);

            double CosteEsperado = 2 * System.Math.Sqrt(2) + 12;
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
        }

        /// <summary>
        /// Prueba un mapa en el que no tiene solucion con movimiento libre
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest1()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, mapa);

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }

        /// <summary>
        /// Prueba un mapa complejo con movimiento libre
        /// </summary>
        [TestMethod]
        public void AlgoritmoTest2()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 0, Y = 3 },
                    new Coordenada() { X = 1, Y = 6 }
                });

            double CosteMenorEsperado = 9 * System.Math.Sqrt(2) + 10;
            double CosteMayorEsperado = 9 * System.Math.Sqrt(2) + 19;
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
            Assert.IsTrue(CosteMenorEsperado <= resultado.Coste);
            Assert.IsTrue(CosteMayorEsperado >= resultado.Coste);
        }

        /// <summary>
        /// Prueba un mapa complejo con movimiento libre
        /// </summary>
        [TestMethod]
        public void AlgoritmoTest3()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 1, Y = 6 },
                    new Coordenada() { X = 0, Y = 3 }
                });

            double CosteMenorEsperado = (3 * System.Math.Sqrt(2)) + 22;
            double CosteMayorEsperado = (3 * System.Math.Sqrt(2)) + 40;
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
            Assert.IsTrue(CosteMenorEsperado <= resultado.Coste);
            Assert.IsTrue(CosteMayorEsperado >= resultado.Coste);
        }

        /// <summary>
        /// Prueba un mapa sin resultado con movimiento libre
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest4()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 1, Y = 6 },
                    new Coordenada() { X = 0, Y = 3 }
                });

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }












        /// <summary>
        /// Prueba un mapa sencillo con movimiento ortogonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest10()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, false, mapa);

            double CosteEsperado = 16;
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
        }

        /// <summary>
        /// Prueba un mapa en el que no tiene solucion con movimiento ortogonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest11()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, false, mapa);

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }

        /// <summary>
        /// Prueba un mapa complejo con movimiento ortogonal
        /// </summary>
        [TestMethod]
        public void AlgoritmoTest12()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 0, Y = 3 },
                    new Coordenada() { X = 1, Y = 6 }
                });

            double CosteMenorEsperado = 28;
            double CosteMayorEsperado = 47;
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
            Assert.IsTrue(CosteMenorEsperado <= resultado.Coste);
            Assert.IsTrue(CosteMayorEsperado >= resultado.Coste);
        }

        /// <summary>
        /// Prueba un mapa complejo con movimiento ortogonal
        /// </summary>
        [TestMethod]
        public void AlgoritmoTest13()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 1, Y = 6 },
                    new Coordenada() { X = 0, Y = 3 }
                });

            double CosteMenorEsperado = (28);
            double CosteMayorEsperado = (46);
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
            Assert.IsTrue(CosteMenorEsperado <= resultado.Coste);
            Assert.IsTrue(CosteMayorEsperado >= resultado.Coste);
        }

        /// <summary>
        /// Prueba un mapa sin resultado con movimiento ortogonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest14()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 1, Y = 6 },
                    new Coordenada() { X = 0, Y = 3 }
                });

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }


        /// <summary>
        /// Prueba un mapa sin resultado con movimiento ortogonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest15()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1){ Permitido=false },new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0){ Permitido=false },new Punto(1,1),new Punto(1,2){ Permitido=false },new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1){ Permitido=false },new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 1, Y = 6 },
                    new Coordenada() { X = 0, Y = 3 }
                });

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }




        /// <summary>
        /// Prueba un mapa sencillo con movimiento diagonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest20()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1),new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, true, false, mapa);

            double CosteEsperado = 13 * System.Math.Sqrt(2);
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.IsTrue(CosteEsperado<= resultado.Coste);
            Assert.IsTrue(CosteEsperado+1 >= resultado.Coste);
            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
        }

        /// <summary>
        /// Prueba un mapa en el que no tiene solucion con movimiento diagonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest21()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, true, false, mapa);

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }

        /// <summary>
        /// Prueba un mapa complejo con movimiento diagonal
        /// </summary>
        [TestMethod]
        public void AlgoritmoTest22()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1),new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, true, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 3, Y = 3 }
                });

            double CosteMenorEsperado = 21;
            double CosteMayorEsperado = 22;
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
            Assert.IsTrue(CosteMenorEsperado <= resultado.Coste);
            Assert.IsTrue(CosteMayorEsperado >= resultado.Coste);
        }

        /// <summary>
        /// Prueba un mapa complejo con movimiento diagonal
        /// </summary>
        [TestMethod]
        public void AlgoritmoTest23()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4),new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5){ Permitido=false },new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0),new Punto(7,1),new Punto(7,2),new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5),new Punto(7,6),new Punto(7,7),new Punto(7,8),new Punto(7,9) },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, true, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 4, Y = 4 }
                });

            double CosteMenorEsperado = (22);
            double CosteMayorEsperado = (23);
            Coordenada inicioEsperado = new Coordenada() { X = 1, Y = 1 };
            Coordenada finEsperado = new Coordenada() { X = 8, Y = 8 };

            Assert.AreEqual(inicioEsperado, resultado.Camino[0]);
            Assert.AreEqual(finEsperado, resultado.Camino[resultado.Camino.Count - 1]);
            Assert.IsTrue(CosteMenorEsperado <= resultado.Coste);
            Assert.IsTrue(CosteMayorEsperado >= resultado.Coste);
        }

        /// <summary>
        /// Prueba un mapa sin resultado con movimiento diagonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest24()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0),new Punto(0,1),new Punto(0,2),new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0),new Punto(2,1),new Punto(2,2),new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, true, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 1, Y = 6 },
                    new Coordenada() { X = 0, Y = 3 }
                });

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }


        /// <summary>
        /// Prueba un mapa sin resultado con movimiento diagonal
        /// </summary>
        [TestMethod()]
        public void AlgoritmoTest25()
        {
            Punto[,] mapa = new Punto[10, 10] {
{new Punto(0,0){ Permitido=false },new Punto(0,1),new Punto(0,2){ Permitido=false },new Punto(0,3),new Punto(0,4),new Punto(0,5),new Punto(0,6),new Punto(0,7),new Punto(0,8),new Punto(0,9) },
{new Punto(1,0),new Punto(1,1),new Punto(1,2),new Punto(1,3),new Punto(1,4),new Punto(1,5),new Punto(1,6),new Punto(1,7),new Punto(1,8),new Punto(1,9) },
{new Punto(2,0){ Permitido=false },new Punto(2,1),new Punto(2,2){ Permitido=false },new Punto(2,3),new Punto(2,4),new Punto(2,5),new Punto(2,6),new Punto(2,7),new Punto(2,8),new Punto(2,9) },
{new Punto(3,0),new Punto(3,1),new Punto(3,2),new Punto(3,3),new Punto(3,4),new Punto(3,5),new Punto(3,6),new Punto(3,7),new Punto(3,8),new Punto(3,9) },
{new Punto(4,0),new Punto(4,1),new Punto(4,2),new Punto(4,3),new Punto(4,4){ Permitido=false },new Punto(4,5){ Permitido=false },new Punto(4,6){ Permitido=false },new Punto(4,7){ Permitido=false },new Punto(4,8){ Permitido=false },new Punto(4,9){ Permitido=false } },
{new Punto(5,0),new Punto(5,1),new Punto(5,2),new Punto(5,3),new Punto(5,4){ Permitido=false},new Punto(5,5),new Punto(5,6),new Punto(5,7),new Punto(5,8),new Punto(5,9) },
{new Punto(6,0),new Punto(6,1),new Punto(6,2),new Punto(6,3),new Punto(6,4){ Permitido=false},new Punto(6,5),new Punto(6,6),new Punto(6,7),new Punto(6,8),new Punto(6,9) },
{new Punto(7,0){ Permitido=false },new Punto(7,1){ Permitido=false },new Punto(7,2){ Permitido=false },new Punto(7,3){ Permitido=false },new Punto(7,4){ Permitido=false },new Punto(7,5){ Permitido=false },new Punto(7,6){ Permitido=false },new Punto(7,7){ Permitido=false },new Punto(7,8){ Permitido=false },new Punto(7,9){ Permitido=false } },
{new Punto(8,0),new Punto(8,1),new Punto(8,2),new Punto(8,3),new Punto(8,4),new Punto(8,5),new Punto(8,6),new Punto(8,7),new Punto(8,8),new Punto(8,9) },
{new Punto(9,0),new Punto(9,1),new Punto(9,2),new Punto(9,3),new Punto(9,4),new Punto(9,5),new Punto(9,6),new Punto(9,7),new Punto(9,8),new Punto(9,9) },
            };
            Coordenada inicio = new Coordenada() { X = 1, Y = 1 };
            Coordenada fin = new Coordenada() { X = 8, Y = 8 };

            AEstrellaResultado resultado = Algoritmia.CalculoAEstrella(inicio, fin, true, false, mapa,
                new Coordenada[] {
                    new Coordenada() { X = 1, Y = 6 },
                    new Coordenada() { X = 0, Y = 3 }
                });

            double CosteEsperado = 0;
            System.Collections.Generic.List<Coordenada> CaminoEsperado = null;
            Assert.AreEqual(CosteEsperado, resultado.Coste);
            Assert.AreEqual(CaminoEsperado, resultado.Camino);
        }

    }

}