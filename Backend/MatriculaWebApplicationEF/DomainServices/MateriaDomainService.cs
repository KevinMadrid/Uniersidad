using MatriculaWebApplicationEF.Models;

namespace MatriculaWebApplicationEF.DomainServices
{
    public class MateriaDomainService
    {
        public string GetMateriaDomainService(int id, Materia materia)
        {
            if (materia == null)
            {
                return "No se Encontro la Materia";
            }

            return null;
        }
        public string PostMateriaDomainService(Materia materia)
        {

            return null;
        }
        public string PutMateriaDomainService(int id, Materia materia)
        {
            if (materia == null)
            {
                return "No se Encontro la Materia";
            }

            return null;
        }
        public string DeleteMateriaDomainService(int id, Materia materia)
        {
            if (materia == null)
            {
                return "No se Encontro la Materia";
            }

            return null;
        }
    }
}
