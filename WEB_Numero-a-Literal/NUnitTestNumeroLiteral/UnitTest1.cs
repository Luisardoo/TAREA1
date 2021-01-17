using NUnit.Framework;
using WEB_Numero_a_Literal.Controllers;

namespace NUnitTestNumeroLiteral
{
    public class TestNLiteral
    {
        private string n;

        [SetUp]
        public void Setup()
        {
        }

        // UNITtest GET
        [Test]
        public void TestNumliteralGET()
        {
            // Arrange = preparacion
            string n = "1234567";
            string esperado = "Un millon Doscientos Treinta y Cuatro mil Quinientos Sesenta y Siete ";
            LiteralController lit = new LiteralController();

            // Act = ejecucion
            string respuesta = lit.NumGet(n);

            // Assert = verificacion
            Assert.AreEqual(esperado, respuesta);

        }
    }
}