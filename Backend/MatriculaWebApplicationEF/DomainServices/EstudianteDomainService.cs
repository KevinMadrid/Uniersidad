using EventMaker.Modelos;
using MatriculaWebApplicationEF.Models;

namespace MatriculaWebApplicationEF.DomainServices
{
    public class EstudianteDomainService
    {
        public string GetEstudianteDomainService(int id, Estudiante estudiante)
        {
            if (estudiante == null)
            {
                return "No se Encontro el Estudiante";
            }

            return null;
        }
        public string PostEstudianteDomainService(Universidad universidad)
        {
            if (universidad.Curso == null)
            {
                return "No se Encontro el Curso";
            }
            if (universidad.Pais == null)
            {
                return "No se Encontro el Pais";
            }
            if (universidad.Profesor == null)
            {
                return "No se Encontro el Profesor";
            }

            var esSexoValid = universidad.Estudiante.Sexo != "M" && universidad.Estudiante.Sexo != "F";
            if (esSexoValid)
            {
                return "El sexo es inválido";
            }

            var esEdadValida = universidad.Estudiante.Edad < 18;

            if (esEdadValida)
            {
                return "Edad es inválida, debe ser mayor a 18";
            }
            return null;
        }
        public string PutEstudianteDomainService(int id, Universidad universidad)
        {
            if (universidad.Estudiante== null)
            {
                return "No se Encontro el Estudiante";
            }
            if (universidad.Curso == null)
            {
                return "No se Encontro el Curso";
            }
            if (universidad.Pais == null)
            {
                return "No se Encontro el Pais";
            }
            if (universidad.Profesor == null)
            {
                return "No se Encontro el Profesor";
            }

            var esSexoValid = universidad.Estudiante.Sexo != "M" && universidad.Estudiante.Sexo != "F";
            if (esSexoValid)
            {
                return "El sexo es inválido";
            }

            var esEdadValida = universidad.Estudiante.Edad < 18;

            if (esEdadValida)
            {
                return "Edad es inválida, debe ser mayor a 18";
            }
            return null;
        }
        public string DeleteEstudianteDomainService(int id, Estudiante estudiante)
        {
            if (estudiante == null)
            {
                return "No se Encontro el Estudiante";
            }

            return null;
        }
    }
}
