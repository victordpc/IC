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
                Valor=9,
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
    }
}