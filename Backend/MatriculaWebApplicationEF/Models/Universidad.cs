using MatriculaWebApplicationEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMaker.Modelos
{
    public class Universidad
    {

        public Universidad(Estudiante estudiante,Curso curso, Pais pais, Profesor profesor)
        {
            Curso = curso;
            Pais = pais;
            Profesor = profesor;
            Estudiante = estudiante;
        }

        public Universidad(Curso curso, Materia materia)
        {
            Curso = curso;
            Materia = materia;
     
        }

    
        public Curso Curso { get; set; }
        public Pais Pais { get; set; }
        public Profesor Profesor { get; set; }
        public Estudiante Estudiante { get; set; }
        public Materia Materia { get; set; }
    }
}
