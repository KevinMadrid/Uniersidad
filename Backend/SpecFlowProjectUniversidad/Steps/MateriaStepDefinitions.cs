using EventMaker.Modelos;
using FluentAssertions;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using TechTalk.SpecFlow;

namespace SpecFlowProjectUniversidad.Steps
{
    [Binding]
    public sealed class MateriaSteps
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
        public MateriaSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"si el materia es igual que null get")]
        public void GivenSiElCursoEsIgualQueNullGet()
        {
            curso = null;
        }

        [When(@"el materia no existe")]
        public void WhenElCursoNoExiste()
        {
            var MateriaDomainService = new MateriaDomainService();
            _resultado = MateriaDomainService.GetMateriaDomainService(id, materia);
        }

        [Then(@"materia enseñar ""(.*)""")]
        public void ThenCursoEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el materia igual que null en post")]
        public void GivenSiElMateriaEsIgualQueNullEnPost()
        {
            materia = null;
        }
        [When(@"el materia no existe en post")]
        public void WhenElMateriaNoExisteEnPost()
        {
            var MateriaDomainService = new MateriaDomainService();
            _resultado = MateriaDomainService.PostMateriaDomainService(materia);
        }

        [Then(@"post materia enseñar ""(.*)""")]
        public void ThenPutMateriaEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el materia igual que null en put")]
        public void GivenSiElMateriaEsIgualQueNullEnPut()
        {
            materia = null;
        }
        [When(@"el materia no existe en put")]
        public void WhenElMateriaNoExisteEnPut()
        {
            var MateriaDomainService = new MateriaDomainService();
            _resultado = MateriaDomainService.PutMateriaDomainService(id, materia);
        }
        [Then(@"put materia enseñar ""(.*)""")]
        public void ThenPutMMaterianEsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }

        [Given(@"si el materia es igual que null en delete")]
        public void GivenSiElMateriaEsIgualQueNullEnDelete()
        {
            materia = null;
        }
        [When(@"el materia no existe en delete")]
        public void WhenElMateriaNoExisteEnDelete()
        {
            id = new int();
            var MateriaDomainService = new MateriaDomainService();
            _resultado = MateriaDomainService.DeleteMateriaDomainService(id, materia);
        }
        [Then(@"delete materia enseñar ""(.*)""")]
        public void ThenDeleteMateriaEnsenar(string p0)
        {
            _resultado.Should().Be(p0);
        }
    }
}
