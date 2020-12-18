using EventMaker.Modelos;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUniversidad.Steps
{
    [Binding]
    public sealed class CursoSteps
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
        public CursoSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"si el curso es igual que null get")]
        public void GivenSiElCursoEsIgualQueNullGet()
        {
            curso = null;
        }

        [When(@"el curso no existe")]
        public void WhenElCursoNoExiste()
        {
            var cursoDomainService = new CursoDomainService();
            _resultado = cursoDomainService.GetCursoDomainService(id, curso);
        }

        [Then(@"curso enseñar ""(.*)""")]
        public void ThenCursoEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si la materia igual que null en post Curso")]
        public void GivenSiElUsuarioEsIgualQueNullEnPostEnCompra()
        {
            materia = null;
        }

        [When(@"el materia no existe en post Curso")]
        public void WhenElUsuarioNoExisteEnPostEnCompra()
        {
            universidad = new Universidad(curso,materia);
            var cursoDomainService = new CursoDomainService();
            _resultado = cursoDomainService.PostCursoDomainService(universidad);
        }

        [Then(@"materia post Curso enseñar ""(.*)""")]
        public void ThenUsuarioPostEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el curso igual que null en put")]
        public void GivenSiElCursoEsIgualQueNullEnPutCompra()
        {
            curso = null;
        }

        [When(@"el curso no existe en put")]
        public void WhenElCursoNoExisteEnPutCompra()
        {
            materia = new Materia();
        
            id = new int();

            universidad = new Universidad(curso,materia);
            var cursoDomainService = new CursoDomainService();
            _resultado = cursoDomainService.PutCursoDomainService(id, universidad);
        }

        [Then(@"put curso enseñar ""(.*)""")]
        public void ThenCursoPutCompraMostrara(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si la materia igual que null en put Curso")]
        public void GivenSiElUsuarioEsIgualQueNullEnPutEnCompra()
        {
            materia = null;
        }

        [When(@"el materia no existe en put Curso")]
        public void WhenElUsuarioNoExisteEnPutEnCompra()
        {
            curso = new Curso();
            id = new int();

            universidad = new Universidad(curso, materia);
            var cursoDomainService = new CursoDomainService();
            _resultado = cursoDomainService.PutCursoDomainService(id,universidad);
        }

        [Then(@"materia put Curso enseñar ""(.*)""")]
        public void ThenUsuarioPutEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el curso es igual que null en delete")]
        public void GivenSiElCursoEsIgualQueNullEnDelete()
        {
            curso = null;
        }
        [When(@"el curso no existe en delete")]
        public void WhenElcursoNoExisteEnDelete()
        {
            id = new int();
            var cursoDomainService = new CursoDomainService();
            _resultado = cursoDomainService.DeleteCursoDomainService(id, curso);
        }
        [Then(@"delete curso enseñar ""(.*)""")]
        public void ThenDeletecursoEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }
    }
}
