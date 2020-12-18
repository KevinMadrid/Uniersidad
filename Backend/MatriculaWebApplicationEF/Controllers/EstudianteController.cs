using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatriculaWebApplicationEF.ApplicationServices;
using MatriculaWebApplicationEF.DataContext;
using MatriculaWebApplicationEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatriculaWebApplicationEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {

        private readonly UniversidadDataContext _baseDatos;
        private readonly EstudianteAppService _estudianteAppService;

        public EstudianteController(UniversidadDataContext baseDeDatos, EstudianteAppService estudianteAppService)
        {
            _baseDatos = baseDeDatos;
            _estudianteAppService = estudianteAppService;

            if (_baseDatos.Estudiantes.Count() == 0)
            {
                _baseDatos.Estudiantes.Add(new Estudiante { Nombre = "Josue", Edad=23,Sexo= "M",IsActive=true , CursoId=1,ProfesorId=1,PaisId=1 });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estudiante>>> GetEstudiantes()
        {
            return await _baseDatos.Estudiantes.Include(q => q.Curso).Include(q => q.Profesor).Include(q => q.Pais).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Estudiante>> GetEstudiante(int id)
        {
            var respuestaEstudianteAppService = await _estudianteAppService.GetEstudianteApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaEstudianteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Estudiantes.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaEstudianteAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Estudiante>> PostEstudiante(Estudiante estudiante)
        {
            var respuestaEstudianteAppService = await _estudianteAppService.PostEstudianteApplicationService(estudiante);

            bool noHayErroresEnLasValidaciones = respuestaEstudianteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetEstudiante), new { id = estudiante.Id }, estudiante);
            }
            return BadRequest(respuestaEstudianteAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstudiante(int id, Estudiante estudiante)
        {
            var respuestaEstudianteAppService = await _estudianteAppService.PutEstudianteApplicationService(id, estudiante);

            bool noHayErroresEnLasValidaciones = respuestaEstudianteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaEstudianteAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstudiante(int id)
        {
            var respuestaEstudianteAppService = await _estudianteAppService.DeletArticulosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaEstudianteAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaEstudianteAppService);
        }
    }
}
