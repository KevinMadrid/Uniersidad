using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MatriculaWebApplicationEF.ApplicationServices;
using MatriculaWebApplicationEF.DataContext;
using MatriculaWebApplicationEF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MatriculaWebApplicationEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {

        private readonly UniversidadDataContext _baseDatos;
        private readonly CursoAppService _cursoAppService;

        public CursoController(UniversidadDataContext baseDeDatos, CursoAppService cursoAppService)
        {
            _baseDatos = baseDeDatos;
            _cursoAppService = cursoAppService;

            if (_baseDatos.Cursos.Count() == 0)
            {
                _baseDatos.Cursos.Add(new Curso { Nombre = "Algebra",MateriaId=1 });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Curso>>> GetCursos()
        {
            return await _baseDatos.Cursos.Include(q => q.materia).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> GetCurso(int id)
        {
            var respuestaCursoAppService = await _cursoAppService.GetCursoApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCursoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Cursos.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaCursoAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Curso>> PostCurso(Curso curso)
        {
            var respuestaCursoAppService = await _cursoAppService.PostCursoApplicationService(curso);

            bool noHayErroresEnLasValidaciones = respuestaCursoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetCurso), new { id = curso.Id }, curso);
            }
            return BadRequest(respuestaCursoAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurso(int id, Curso curso)
        {
            var respuestaCursoAppService = await _cursoAppService.PutCursoApplicationService(id, curso);

            bool noHayErroresEnLasValidaciones = respuestaCursoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaCursoAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurso(int id)
        {
            var respuestaCursoAppService = await _cursoAppService.DeletArticulosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaCursoAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaCursoAppService);
        }

    }
}
