using EventMaker.Modelos;
using MatriculaWebApplicationEF.Models;

namespace MatriculaWebApplicationEF.DomainServices
{
    public class CursoDomainService
    {
        public string GetCursoDomainService(int id, Curso curso)
        {
            if (curso == null)
            {
                return "No se Encontro el Curso";
            }

            return null;
        }
        public string PostCursoDomainService(Universidad universidad)
        {
            if (universidad.Materia == null)
            {
                return "No se Encontro la Materia";
            }
            return null;
        }
        public string PutCursoDomainService(int id, Universidad universidad)
        {
            if (universidad.Curso == null)
            {
                return "No se Encontro el Curso";
            }
            if (universidad.Materia== null)
            {
                return "No se Encontro la Materia";
            }
            return null;
        }
        public string DeleteCursoDomainService(int id, Curso curso)
        {
            if (curso == null)
            {
                return "No se Encontro el Curso";
            }

            return null;
        }
    }
}
