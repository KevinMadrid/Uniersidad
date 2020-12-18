using EventMaker.Modelos;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUniversidad.Steps
{
    [Binding]
    public sealed class PaisSteps
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
        public PaisSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"si el pais es igual que null get")]
        public void GivenSiElPaisEsIgualQueNullGet()
        {
            pais = null;
        }

        [When(@"el pais no existe")]
        public void WhenElPaisNoExiste()
        {
            var paisDomainService = new PaisDomainService();
            _resultado = paisDomainService.GetPaisDomainService(id, pais);
        }

        [Then(@"pais enseñar ""(.*)""")]
        public void ThenPaisEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }


        [Given(@"si el pais igual que null en put")]
        public void GivenSiElPaisEsIgualQueNullEnPut()
        {
            pais = null;
        }
        [When(@"el pais no existe en put")]
        public void WhenElPaisNoExisteEnPut()
        {
            var PaisDomainService = new PaisDomainService();
            _resultado = PaisDomainService.PutPaisDomainService(id, pais);
        }
        [Then(@"put pais enseñar ""(.*)""")]
        public void ThenPutPaisEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el pais es igual que null en delete")]
        public void GivenSiElPaisEsIgualQueNullEnDelete()
        {
            pais = null;
        }
        [When(@"el pais no existe en delete")]
        public void WhenElPaisNoExisteEnDelete()
        {
            id = new int();
            var PaisDomainService = new PaisDomainService();
            _resultado = PaisDomainService.DeletePaisDomainService(id, pais);
        }
        [Then(@"delete pais enseñar ""(.*)""")]
        public void ThenDeletePaisEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }
    }
}
