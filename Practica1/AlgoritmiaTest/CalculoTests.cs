using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Algoritmia.Tests
{
    [TestClass()]
    public class CalculoTests
    {
        [TestMethod()]
        public void DistanciaTest()
        {
            Punto uno = new Punto(2, 2);
            Punto dos = new Punto(3, 3);

            double resultado = Math.Sqrt(2);
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }

        [TestMethod()]
        public void DistanciaTest1()
        {
            Punto uno = new Punto(2, 2);
            Punto dos = new Punto(3, 2);

            double resultado = 1;
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }

        [TestMethod()]
        public void DistanciaTest2()
        {
            Punto uno = new Punto(2, 2);
            Coordenada dos = new Coordenada() { X = 3, Y = 3 };

            double resultado = Math.Sqrt(2);
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }

        [TestMethod()]
        public void DistanciaTest3()
        {
            Punto uno = new Punto(2, 2);
            Coordenada dos = new Coordenada() { X = 3, Y = 2 };

            double resultado = 1;
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }
        [TestMethod()]
        public void DistanciaTest4()
        {
            Coordenada uno = new Coordenada() { X = 2, Y = 2 };
            Punto dos = new Punto(3, 3);

            double resultado = Math.Sqrt(2);
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }
        [TestMethod()]
        public void DistanciaTest5()
        {
            Coordenada uno = new Coordenada() { X = 2, Y = 2 };
            Punto dos = new Punto(3, 2);

            double resultado = 1;
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }
        [TestMethod()]
        public void DistanciaTest6()
        {
            Coordenada uno = new Coordenada() { X = 2, Y = 2 };
            Coordenada dos = new Coordenada() { X = 3, Y = 3 };

            double resultado = Math.Sqrt(2);
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }
        [TestMethod()]
        public void DistanciaTest7()
        {
            Coordenada uno = new Coordenada() { X = 2, Y = 2 };
            Coordenada dos = new Coordenada() { X = 3, Y = 2 };

            double resultado = 1;
            Assert.AreEqual(resultado, Calculo.Distancia(uno, dos));
        }
    }
}