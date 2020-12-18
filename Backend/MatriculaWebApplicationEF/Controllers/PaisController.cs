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
    public class PaisController : ControllerBase
    {

        private readonly UniversidadDataContext _baseDatos;
        private readonly PaisAppService _paisAppService;

        public PaisController(UniversidadDataContext baseDeDatos, PaisAppService paisAppService)
        {
            _baseDatos = baseDeDatos;
            _paisAppService = paisAppService;

            if (_baseDatos.Pais.Count() == 0)
            {
                _baseDatos.Pais.Add(new Pais { Nombre = "Holanda" });
                _baseDatos.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pais>>> GetPaieses()
        {
            return await _baseDatos.Pais.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pais>> GetPais(int id)
        {
            var respuestaPaisAppService = await _paisAppService.GetPaisApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPaisAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return await _baseDatos.Pais.FirstOrDefaultAsync(q => q.Id == id);
            }
            return BadRequest(respuestaPaisAppService);

        }

        [HttpPost]
        public async Task<ActionResult<Pais>> PostCurso(Pais pais)
        {
            var respuestaPaisAppService = await _paisAppService.PostPaisApplicationService(pais);

            bool noHayErroresEnLasValidaciones = respuestaPaisAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return CreatedAtAction(nameof(GetPais), new { id = pais.Id }, pais);
            }
            return BadRequest(respuestaPaisAppService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPais(int id, Pais pais)
        {
            var respuestaPaisAppService = await _paisAppService.PutPaisApplicationService(id, pais);

            bool noHayErroresEnLasValidaciones = respuestaPaisAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return NoContent();
            }
            return BadRequest(respuestaPaisAppService);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePais(int id)
        {
            var respuestaPaisAppService = await _paisAppService.DeletPaisApplicationService(id);

            bool noHayErroresEnLasValidaciones = respuestaPaisAppService == null;
            if (noHayErroresEnLasValidaciones)
            {
                return Ok("success");
            }
            return BadRequest(respuestaPaisAppService);
        }

    }
}
