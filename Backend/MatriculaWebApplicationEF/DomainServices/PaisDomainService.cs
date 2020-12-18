using MatriculaWebApplicationEF.Models;

namespace MatriculaWebApplicationEF.DomainServices
{
    public class PaisDomainService
    {
        public string GetPaisDomainService(int id, Pais pais)
        {
            if (pais == null)
            {
                return "No se Encontro el Pais";
            }

            return null;
        }
        public string PostPaisDomainService(Pais pais)
        {

            return null;
        }
        public string PutPaisDomainService(int id, Pais pais)
        {
            if (pais == null)
            {
                return "No se Encontro el Pais";
            }

            return null;
        }
        public string DeletePaisDomainService(int id, Pais pais)
        {
            if (pais == null)
            {
                return "No se Encontro el Pais";
            }

            return null;
        }
    }
}
