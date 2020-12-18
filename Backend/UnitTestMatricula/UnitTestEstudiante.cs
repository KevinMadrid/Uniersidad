using EventMaker.Modelos;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMatricula
{
    [TestClass]
    public class UnitTestEstudiante
    {

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnEstudianteGet()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            estudiante = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.GetEstudianteDomainService(id, estudiante);

            // Assert
            Assert.AreEqual("No se Encontro el Estudiante", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCursoPost()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            curso = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.PostEstudianteDomainService(universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Curso", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPaisPost()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            pais = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.PostEstudianteDomainService(universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Pais", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnProfesorPost()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            profesor = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.PostEstudianteDomainService(universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Profesor", resultado);
        }

        [TestMethod]
        public void ValidarEdadEstudianteMenorA18()
        {
            //Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var universidad = new Universidad(estudiante, curso, pais, profesor);

            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 14;
            estudiante.Sexo = "M";

            //Act
            var respuesta = estudianteDomainService.PostEstudianteDomainService(universidad);

            //Assert
            Assert.AreEqual("Edad es inválida, debe ser mayor a 18", respuesta);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnEstudiantePut()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            estudiante = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.PutEstudianteDomainService(id,universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Estudiante", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnCursoPut()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            curso = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.PutEstudianteDomainService(id,universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Curso", resultado);
        }

        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnPaisPut()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            pais = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.PutEstudianteDomainService(id,universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Pais", resultado);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnProfesorPut()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            profesor = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.PutEstudianteDomainService(id,universidad);

            // Assert
            Assert.AreEqual("No se Encontro el Profesor", resultado);
        }
        [TestMethod]
        public void ValidarEdadEstudianteMenorA18put()
        {
            //Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            var universidad = new Universidad(estudiante, curso, pais, profesor);

            EstudianteDomainService estudianteDomainService = new EstudianteDomainService();
            estudiante.Nombre = "Test Vanguardia";
            estudiante.Edad = 14;
            estudiante.Sexo = "M";

            //Act
            var respuesta = estudianteDomainService.PutEstudianteDomainService(id,universidad);

            //Assert
            Assert.AreEqual("Edad es inválida, debe ser mayor a 18", respuesta);
        }
        [TestMethod]
        public void PruebaParaValidarQueSeEncuentraUnEstudianteDelete()
        {
            // Arrange
            var curso = new Curso();
            var estudiante = new Estudiante();
            var profesor = new Profesor();
            var pais = new Pais();
            var id = new int();
            estudiante = null;
            var universidad = new Universidad(estudiante, curso, pais, profesor);
            // Act
            var estudianteDomainService = new EstudianteDomainService();
            var resultado = estudianteDomainService.DeleteEstudianteDomainService(id,estudiante);

            // Assert
            Assert.AreEqual("No se Encontro el Estudiante", resultado);
        }
    } 
}
