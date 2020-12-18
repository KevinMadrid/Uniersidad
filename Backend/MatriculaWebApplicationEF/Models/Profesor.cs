using System.Collections.Generic;

namespace MatriculaWebApplicationEF.Models
{
    public class Profesor   
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
    }
}
