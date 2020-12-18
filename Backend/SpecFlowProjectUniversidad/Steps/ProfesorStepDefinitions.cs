using EventMaker.Modelos;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUniversidad.Steps
{
    [Binding]
    public sealed class ProfesorSteps
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
        public ProfesorSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"si el profesor es igual que null get")]
        public void GivenSiElProfesorEsIgualQueNullGet()
        {
            profesor = null;
        }

        [When(@"el profesor no existe")]
        public void WhenElProfesorNoExiste()
        {
            var ProfesorDomainService = new ProfesorDomainService();
            _resultado = ProfesorDomainService.GetProfesorDomainService(id, profesor);
        }

        [Then(@"profesor enseñar ""(.*)""")]
        public void ThenProfesorEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }


        [Given(@"si el profesor igual que null en put")]
        public void GivenSiElProfesorEsIgualQueNullEnPut()
        {
            profesor = null;
        }
        [When(@"el profesor no existe en put")]
        public void WhenElProfesorNoExisteEnPut()
        {
            var ProfesorDomainService = new ProfesorDomainService();
            _resultado = ProfesorDomainService.PutProfesorDomainService(id, profesor);
        }
        [Then(@"put profesor enseñar ""(.*)""")]
        public void ThenPutProfesorEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el profesor es igual que null en delete")]
        public void GivenSiElProfesorEsIgualQueNullEnDelete()
        {
            profesor = null;
        }
        [When(@"el profesor no existe en delete")]
        public void WhenElProfesorNoExisteEnDelete()
        {
            id = new int();
            var ProfesorDomainService = new ProfesorDomainService();
            _resultado = ProfesorDomainService.DeleteProfesorDomainService(id, profesor);
        }
        [Then(@"delete profesor enseñar ""(.*)""")]
        public void ThenDeleteProfesorEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }
    }
}
