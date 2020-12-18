using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestPais
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPais()
        {
            // Arrange
            var pais= new Pais();
            var id = new int();
            pais = null;
            // Act
            var paisDomainService = new PaisDomainService();
            var resultado = paisDomainService.GetPaisDomainService(id, pais);

            // Assert
            Assert.AreEqual("No se Encontro el Pais", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPais2()
        {
            // Arrange
            var pais = new Pais();
            var id = new int();
            pais = null;
            // Act
            var paisDomainService = new PaisDomainService();
            var resultado = paisDomainService.PutPaisDomainService(id, pais);

            // Assert
            Assert.AreEqual("No se Encontro el Pais", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnInvitado3()
        {
            // Arrange
            var pais = new Pais();
            var id = new int();
            pais = null;
            // Act
            var paisDomainService = new PaisDomainService();
            var resultado = paisDomainService.DeletePaisDomainService(id, pais);

            // Assert
            Assert.AreEqual("No se Encontro el Pais", resultado);
        }
    }
}
