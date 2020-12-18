using EventMaker.Modelos;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUniversidad.Steps
{
    [Binding]
    public sealed class EstudianteSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private Curso curso;
        private Materia materia;
        private Estudiante estudiante;
        private Pais pais;
        private Profesor profesor;
        private Universidad universidad;
        private string _resultado;
        int id;
        public EstudianteSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"si el estudiante es igual que null get")]
        public void GivenSiElEstudianteEsIgualQueNullGet()
        {
            estudiante = null;
        }

        [When(@"el estudiante no existe")]
        public void WhenElEstudianteNoExiste()
        {
            var EstudianteDomainService = new EstudianteDomainService();
            _resultado = EstudianteDomainService.GetEstudianteDomainService(id, estudiante);
        }

        [Then(@"estudiante enseñar ""(.*)""")]
        public void ThenEstudianteEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el curso igual que null en post Estudiante")]
        public void GivenSiElCursoEsIgualQueNullEnPostEnEstudiante()
        {
            curso = null;
        }

        [When(@"el curso no existe en post Estudiante")]
        public void WhenElCursoNoExisteEnPostEnEstudiante()
        {

            universidad = new Universidad(estudiante, curso, pais, profesor);
            var estudianteDomainService = new EstudianteDomainService();
            _resultado = estudianteDomainService.PostEstudianteDomainService(universidad);
        }

        [Then(@"curso post Estudiante enseñar ""(.*)""")]
        public void ThenCursoPostEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el pais igual que null en post Estudiante")]
        public void GivenSiElPaisEsIgualQueNullEnPostEnEstudiante()
        {
            pais = null;
        }

        [When(@"el pais no existe en post Estudiante")]
        public void WhenElPaisNoExisteEnPostEnEstudiante()
        {

            universidad = new Universidad(estudiante, curso, pais, profesor);
            var estudianteDomainService = new EstudianteDomainService();
            _resultado = estudianteDomainService.PostEstudianteDomainService(universidad);
        }

        [Then(@"pais post Estudiante enseñar ""(.*)""")]
        public void ThenPaisPostEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el estudiante igual que null en put")]
        public void GivenSiElEstudianteEsIgualQueNullEnPutEstudiante()
        {
            estudiante = null;
        }

        [When(@"el estudiante no existe en put")]
        public void WhenElEstudianteNoExisteEnPutEstudiante()
        {
            curso = new Curso();
            pais = new Pais();
            profesor = new Profesor();

            id = new int();

            universidad = new Universidad( estudiante, curso, pais, profesor);
            var estudianteDomainService = new EstudianteDomainService();
            _resultado = estudianteDomainService.PutEstudianteDomainService(id, universidad);
        }

        [Then(@"put estudiante enseñar ""(.*)""")]
        public void ThenEstudiantePutCompraMostrara(string p0)
        {
            _resultado.Should().Be(p0);
        }
        [Given(@"si el curso igual que null en put Estudiante")]
        public void GivenSiElCursoEsIgualQueNullEnPutEstudiante()
        {
            curso = null;
        }

        [When(@"el curso no existe en put Estudiante")]
        public void WhenElEstudianteNoExisteEnPutCompra()
        {
            estudiante = new Estudiante();
            pais = new Pais();
            profesor = new Profesor();

            id = new int();

            universidad = new Universidad(estudiante, curso, pais, profesor);
            var estudianteDomainService = new EstudianteDomainService();
            _resultado = estudianteDomainService.PutEstudianteDomainService(id, universidad);
        }

        [Then(@"curso put Estudiante enseñar ""(.*)""")]
        public void ThenCursoPutEstudianteMostrara(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el pais igual que null en put Estudiante")]
        public void GivenSiElPaisEsIgualQueNullEnPutEstudiante()
        {
            pais = null;
        }

        [When(@"el pais no existe en put Estudiante")]
        public void WhenElPaisNoExisteEnPutEstudiante()
        {
            estudiante = new Estudiante();
            curso = new Curso();
            profesor = new Profesor();

            id = new int();

            universidad = new Universidad(estudiante, curso, pais, profesor);
            var estudianteDomainService = new EstudianteDomainService();
            _resultado = estudianteDomainService.PutEstudianteDomainService(id, universidad);
        }

        [Then(@"pais put Estudiante enseñar ""(.*)""")]
        public void ThenPaisPutEstudianteMostrara(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el profesor igual que null en put Estudiante")]
        public void GivenSiElProfesorEsIgualQueNullEnPutEstudiante()
        {
            profesor = null;
        }

        [When(@"el profesor no existe en put Estudiante")]
        public void WhenElProfesorNoExisteEnPutEstudiante()
        {
            estudiante = new Estudiante();
            curso = new Curso();
            pais = new Pais();

            id = new int();

            universidad = new Universidad(estudiante, curso, pais, profesor);
            var estudianteDomainService = new EstudianteDomainService();
            _resultado = estudianteDomainService.PutEstudianteDomainService(id, universidad);
        }

        [Then(@"profesor put Estudiante enseñar ""(.*)""")]
        public void ThenProfesorPutEstudianteMostrara(string p0)
        {
            _resultado.Should().Be(p0);
        }
      

        [Given(@"si el estudiante es igual que null en delete")]
        public void GivenSiElEstudianteEsIgualQueNullEnDelete()
        {
            estudiante = null;
        }
        [When(@"el estudiante no existe en delete")]
        public void WhenElEstudianteNoExisteEnDelete()
        {
            id = new int();
            var estudianteDomainService = new EstudianteDomainService();
            _resultado = estudianteDomainService.DeleteEstudianteDomainService(id, estudiante);
        }
        [Then(@"delete estudiante enseñar ""(.*)""")]
        public void ThenDeleteEstudianteEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }
    }
}
