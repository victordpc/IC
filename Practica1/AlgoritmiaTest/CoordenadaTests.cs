using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algoritmia.Tests
{
    [TestClass()]
    public class CoordenadaTests
    {
        [TestMethod()]
        public void GetHashCodeTest()
        {
            int obtenido = new Coordenada() { X = 2, Y = 4 }.GetHashCode();
            int esperado = 859600089;
            Assert.AreEqual(esperado, obtenido);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string obtenido = new Coordenada() { X = 2, Y = 4 }.ToString();
            string esperado= "X: 2 Y: 4" ;
            Assert.AreEqual(esperado, obtenido);
        }

    }
}