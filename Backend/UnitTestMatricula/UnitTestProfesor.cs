using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestProfesor
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPais()
        {
            // Arrange
            var profesor= new Profesor();
            var id = new int();
            profesor = null;
            // Act
            var profesorDomainService = new ProfesorDomainService();
            var resultado = profesorDomainService.GetProfesorDomainService(id, profesor);

            // Assert
            Assert.AreEqual("No se Encontro el Profesor", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPais2()
        {
            // Arrange
            var profesor = new Profesor();
            var id = new int();
            profesor = null;
            // Act
            var profesorDomainService = new ProfesorDomainService();
            var resultado = profesorDomainService.PutProfesorDomainService(id, profesor);

            // Assert
            Assert.AreEqual("No se Encontro el Profesor", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnInvitado3()
        {
            // Arrange
            var profesor = new Profesor();
            var id = new int();
            profesor = null;
            // Act
            var profesorDomainService = new ProfesorDomainService();
            var resultado = profesorDomainService.DeleteProfesorDomainService(id, profesor);

            // Assert
            Assert.AreEqual("No se Encontro el Profesor", resultado);
        }
    }
}
