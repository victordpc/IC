using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmia.Tests
{
    [TestClass()]
    public class PuntoTests
    {
        [TestMethod()]
        public void PuntoTest()
        {
            Punto prueba = new Punto(3, 4);

            Assert.AreEqual(3, prueba.X);
            Assert.AreEqual(4, prueba.Y);
            Assert.AreEqual(null, prueba.Abierto);
            Assert.AreEqual(0, prueba.G);
            Assert.AreEqual(0, prueba.H);
            Assert.AreEqual(0, prueba.F);
            Assert.AreEqual(true, prueba.Permitido);
            Assert.AreEqual(0, prueba.Valor);
        }

        [TestMethod()]
        public void PuntoTest2()
        {
            Punto prueba = new Punto(3, 4, abierto: true);

            Assert.AreEqual(3, prueba.X);
            Assert.AreEqual(4, prueba.Y);
            Assert.AreEqual(true, prueba.Abierto);
            Assert.AreEqual(0, prueba.G);
            Assert.AreEqual(0, prueba.H);
            Assert.AreEqual(0, prueba.F);
            Assert.AreEqual(true, prueba.Permitido);
            Assert.AreEqual(0, prueba.Valor);
        }

        [TestMethod()]
        public void PuntoTest3()
        {
            Punto prueba = new Punto(3, 4, abierto: false);

            Assert.AreEqual(3, prueba.X);
            Assert.AreEqual(4, prueba.Y);
            Assert.AreEqual(false, prueba.Abierto);
            Assert.AreEqual(0, prueba.G);
            Assert.AreEqual(0, prueba.H);
            Assert.AreEqual(0, prueba.F);
            Assert.AreEqual(true, prueba.Permitido);
            Assert.AreEqual(0, prueba.Valor);
        }

        [TestMethod()]
        public void PuntoTest4()
        {
            Punto prueba = new Punto(3, 4, abierto: false)
            {
                G = 10,
                H = 15,
                Valor = 9,
            };
            Assert.AreEqual(3, prueba.X);
            Assert.AreEqual(4, prueba.Y);
            Assert.AreEqual(false, prueba.Abierto);
            Assert.AreEqual(10, prueba.G);
            Assert.AreEqual(15, prueba.H);
            Assert.AreEqual(34, prueba.F);
            Assert.AreEqual(true, prueba.Permitido);
            Assert.AreEqual(9, prueba.Valor);
        }
        [TestMethod()]
        public void GetCoordenadaTest()
        {
            Punto prueba;
            prueba = new Punto(3, 4, abierto: false);

            Coordenada prueba2 = new Coordenada { X = 3, Y = 4 };
            Assert.AreEqual(prueba2.X, prueba.GetCoordenada().X);
            Assert.AreEqual(prueba2.Y, prueba.GetCoordenada().Y);
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Punto prueba = new Punto(3, 4, abierto: false);
            Punto prueba2 = new Punto(3, 4, abierto: false);

            Assert.IsTrue(prueba.Equals(prueba2));
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            int obtenido = new Punto(2, 4, true).GetHashCode();
            int esperado = -1478831780;
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string obtenido = new Punto(2, 4, true).ToString();
            string esperado = "X: 2; Y: 4; H: 0; G: 0; F: 0; Valor: 0; Abierto: True; Permitido: True;";
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod()]
        public void ToStringTest2()
        {
            Punto punto = new Punto(2, 4, true);
            punto.G = 2;
            punto.H = 3;
            punto.Permitido = false;
            punto.Valor = 5;
            string obtenido = punto.ToString();
            string esperado = "X: 2; Y: 4; H: 3; G: 2; F: 10; Valor: 5; Abierto: True; Permitido: False;";
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod()]
        public void EqualsTest2()
        {
            Punto punto = new Punto(2, 4, true)
            {
                G = 2,
                H = 3,
                Permitido = false,
                Valor = 5
            };

            Punto punto2 = new Punto(2, 4, true)
            {
                G = 2,
                H = 3,
                Permitido = false,
                Valor = 5
            };

            Assert.IsTrue(punto.Equals(punto2));
        }


        [TestMethod()]
        public void EqualsTest3()
        {
            Punto punto = new Punto(2, 4, true)
            {
                G = 2,
                H = 3,
                Permitido = false,
                Valor = 5
            };

            Punto punto2 = new Punto(2, 4, true)
            {
                G = 2,
                H = 3,
                Permitido = false,
                Valor = 6
            };

            Assert.IsFalse(punto.Equals(punto2));
        }
    }
}