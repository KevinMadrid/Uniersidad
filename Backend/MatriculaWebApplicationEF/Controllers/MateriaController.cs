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
    public class MateriaController : ControllerBase
    {

        private readonly UniversidadDataContext _baseDatos;
        private readonly MateriaAppService _materiaAppService;

        public MateriaController(UniversidadDataContext baseDeDatos, MateriaAppService materiaAppService)
        {
            _baseDatos = baseDeDatos;
            _materiaAppService = materiaAppService;

            if (_baseDatos.Materias.Count() == 0)
            {
                _baseDatos.Materias.Add(new Materia { Nombre = "Quimica 1 " });
                _baseDatos.Materias.Add(new Materia { Nombre = "Introduccion al Algebra " });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Materia>>> GetMaterias()
        {
            return await _baseDatos.Materias.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Materia>> GetMateria(int id)
        {
            var respuestaMateriaAppService = await _materiaAppService.GetMateriaApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaMateriaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Materias.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaMateriaAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Materia>> PostMateria(Materia materia)
        {
            var respuestaMateriaAppService = await _materiaAppService.PostMateriaApplicationService(materia);

            bool noHayErroresEnLasValidaciones = respuestaMateriaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetMateria), new { id = materia.Id }, materia);
            }
            return BadRequest(respuestaMateriaAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMateria(int id, Materia Materia)
        {
            var respuestaMateriaAppService = await _materiaAppService.PutMateriaApplicationService(id, Materia);

            bool noHayErroresEnLasValidaciones = respuestaMateriaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaMateriaAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMateria(int id)
        {
            var respuestaMateriaAppService = await _materiaAppService.DeletArticulosApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaMateriaAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaMateriaAppService);
        }

    }
}
