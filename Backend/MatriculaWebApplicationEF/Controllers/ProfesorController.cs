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
    public class ProfesorController : ControllerBase
    {

        private readonly UniversidadDataContext _baseDatos;
        private readonly ProfesorAppService _profesorAppService;

        public ProfesorController(UniversidadDataContext baseDeDatos, ProfesorAppService profesorAppService)
        {
            _baseDatos = baseDeDatos;
            _profesorAppService = profesorAppService;

            if (_baseDatos.Profesors.Count() == 0)
            {
                _baseDatos.Profesors.Add(new Profesor { Nombre = "Mario" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesor>>> GetProfesors()
        {
            return await _baseDatos.Profesors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Profesor>> GetProfesor(int id)
        {
            var respuestaProfesorAppService = await _profesorAppService.GetProfesorApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaProfesorAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Profesors.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaProfesorAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Profesor>> PostCurso(Profesor profesor)
        {
            var respuestaProfesorAppService = await _profesorAppService.PostProfesorApplicationService(profesor);

            bool noHayErroresEnLasValidaciones = respuestaProfesorAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetProfesor), new { id = profesor.Id }, profesor);
            }
            return BadRequest(respuestaProfesorAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesor(int id, Profesor profesor)
        {
            var respuestaProfesorAppService = await _profesorAppService.PutProfesorApplicationService(id, profesor);

            bool noHayErroresEnLasValidaciones = respuestaProfesorAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaProfesorAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            var respuestaProfesorAppService = await _profesorAppService.DeletProfesorApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaProfesorAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaProfesorAppService);
        }

    }
}
