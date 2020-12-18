using System.Collections.Generic;

namespace MatriculaWebApplicationEF.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Curso> Cursos{ get; set; }
    }
}
