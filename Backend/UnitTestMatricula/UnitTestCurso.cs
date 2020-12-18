using EventMaker.Modelos;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestCurso
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCursoGet()
        {
            // Arrange
            var curso = new Curso();
            var materia= new Materia();
            var id = new int();
            curso = null;
            var universidad = new Universidad (curso,  materia);
            // Act
            var cursoDomainService= new CursoDomainService();
            var resultado = cursoDomainService.GetCursoDomainService(id, curso);

            // Assert
            Assert.AreEqual("No se Encontro el Curso", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaMateriaPost()
        {
            // Arrange
            var curso = new Curso();
            var materia = new Materia();
            var id = new int();
            materia = null;
            var universidad = new Universidad(curso, materia);
            // Act
            var cursoDomainService = new CursoDomainService();
            var resultado = cursoDomainService.PostCursoDomainService(universidad);

            // Assert
            Assert.AreEqual("No se Encontro la Materia", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCursoPut()
        {
            // Arrange
            var curso = new Curso();
            var materia = new Materia();
            var id = new int();
            curso = null;
            var universidad = new Universidad(curso, materia);
            // Act
            var cursoDomainService = new CursoDomainService();
            var resultado = cursoDomainService.PutCursoDomainService(id,universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Curso", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnaMateriaPut()
        { // Arrange
            var curso = new Curso();
            var materia = new Materia();
            var id = new int();
            materia = null;
            var universidad = new Universidad(curso, materia);
            // Act
            var cursoDomainService = new CursoDomainService();
            var resultado = cursoDomainService.PutCursoDomainService(id, universidad);

            // Assert
            Assert.AreEqual("No se Encontro la Materia", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCursoDelete()
        {
            // Arrange
            var curso = new Curso();
            var materia = new Materia();
            var id = new int();
            curso = null;
            var universidad = new Universidad(curso, materia);
            // Act
            var cursoDomainService = new CursoDomainService();
            var resultado = cursoDomainService.DeleteCursoDomainService(id, curso);
            // Assert
            Assert.AreEqual("No se Encontro el Curso", resultado);
        }
    }
}
