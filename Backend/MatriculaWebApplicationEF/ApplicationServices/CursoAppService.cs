using EventMaker.Modelos;
using MatriculaWebApplicationEF.DataContext;
using MatriculaWebApplicationEF.DomainServices;
using MatriculaWebApplicationEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatriculaWebApplicationEF.ApplicationServices
{
    public class CursoAppService
    {
        private readonly UniversidadDataContext _baseDatos;
        private readonly CursoDomainService _cursoDomainServices;

        public CursoAppService(UniversidadDataContext _context, CursoDomainService cursoDomainService)
        {
            _baseDatos = _context;
            _cursoDomainServices = cursoDomainService;
        }

        public async Task<String> GetCursoApplicationService(int id)
        {
            var curso = await _baseDatos.Cursos.Include(q => q.materia).FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _cursoDomainServices.GetCursoDomainService(id, curso);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostCursoApplicationService(Curso curso)

        {
            Universidad universidad= await LlamadaALaBaseDeDatos(curso);

            var respuestaDomainService = _cursoDomainServices.PostCursoDomainService(universidad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Cursos.Add(curso);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        private async Task<Universidad> LlamadaALaBaseDeDatos(Curso curso)
        {
            Materia materia= await _baseDatos.Materias.FirstOrDefaultAsync(q => q.Id == curso.MateriaId);


            var universidad = new Universidad(curso, materia);
            return universidad;
        }


        public async Task<String> PutCursoApplicationService(int id, Curso curso)
        {
            Universidad universidad = await LlamadaALaBaseDeDatos(curso);

            var respuestaDomainService = _cursoDomainServices.PutCursoDomainService(id, universidad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(curso).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletArticulosApplicationService(int id)
        {
            var curso = await _baseDatos.Cursos.FindAsync(id);
            var respuestaDomainService = _cursoDomainServices.DeleteCursoDomainService(id, curso);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Cursos.Remove(curso);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
