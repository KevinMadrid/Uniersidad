using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestMateria
    {
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnMateria()
        {
            // Arrange
            var materia = new Materia();
            var id = new int();
            materia = null;
            // Act
            var materiaDomainService = new MateriaDomainService();
            var resultado = materiaDomainService.GetMateriaDomainService(id, materia);

            // Assert
            Assert.AreEqual("No se Encontro la Materia", resultado);
        }


        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnMateria2()
        {
            // Arrange
            var materia = new Materia();
            var id = new int();
            materia = null;
            // Act
            var materiaDomainService = new MateriaDomainService();
            var resultado = materiaDomainService.PutMateriaDomainService(id, materia);

            // Assert
            Assert.AreEqual("No se Encontro la Materia", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnInvitado3()
        {
            // Arrange
            var materia = new Materia();
            var id = new int();
            materia = null;
            // Act
            var materiaDomainService = new MateriaDomainService();
            var resultado = materiaDomainService.DeleteMateriaDomainService(id, materia);

            // Assert
            Assert.AreEqual("No se Encontro la Materia", resultado);
        }
    }
}
