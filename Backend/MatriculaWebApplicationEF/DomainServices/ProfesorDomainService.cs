using MatriculaWebApplicationEF.Models;

namespace MatriculaWebApplicationEF.DomainServices
{
    public class ProfesorDomainService
    {
        public string GetProfesorDomainService(int id, Profesor profesor)
        {
            if (profesor == null)
            {
                return "No se Encontro el Profesor";
            }

            return null;
        }
        public string PostProfesorDomainService(Profesor profesor)
        {

            return null;
        }
        public string PutProfesorDomainService(int id, Profesor profesor)
        {
            if (profesor == null)
            {
                return "No se Encontro el Profesor";
            }

            return null;
        }
        public string DeleteProfesorDomainService(int id, Profesor profesor)
        {
            if (profesor == null)
            {
                return "No se Encontro el Profesor";
            }

            return null;
        }
    }
}
