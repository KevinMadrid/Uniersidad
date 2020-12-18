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
    public class EstudianteAppService
    {
        private readonly UniversidadDataContext _baseDatos;
        private readonly EstudianteDomainService _estudianteDomainServices;

        public EstudianteAppService(UniversidadDataContext _context, EstudianteDomainService estudianteDomainService)
        {
            _baseDatos = _context;
            _estudianteDomainServices = estudianteDomainService;
        }

        public async Task<String> GetEstudianteApplicationService(int id)
        {
            var estudiante = await _baseDatos.Estudiantes.Include(q => q.Curso).Include(q => q.Profesor).Include(q => q.Pais).FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _estudianteDomainServices.GetEstudianteDomainService(id, estudiante);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostEstudianteApplicationService(Estudiante estudiante)

        {
            Universidad universidad = await LlamadaALaBaseDeDatos(estudiante);

            var respuestaDomainService = _estudianteDomainServices.PostEstudianteDomainService(universidad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Estudiantes.Add(estudiante);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        private async Task<Universidad> LlamadaALaBaseDeDatos(Estudiante estudiante)
        {
            Curso curso= await _baseDatos.Cursos.FirstOrDefaultAsync(q => q.Id == estudiante.CursoId);

            Profesor profesor = await _baseDatos.Profesors.FirstOrDefaultAsync(q => q.Id == estudiante.ProfesorId);

            Pais pais= await _baseDatos.Pais.FirstOrDefaultAsync(q => q.Id == estudiante.PaisId);


            var universidad = new Universidad( estudiante, curso, pais, profesor);
            return universidad;
        }


        public async Task<String> PutEstudianteApplicationService(int id, Estudiante estudiante)
        {
            Universidad universidad = await LlamadaALaBaseDeDatos(estudiante);

            var respuestaDomainService = _estudianteDomainServices.PutEstudianteDomainService(id, universidad);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(estudiante).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletArticulosApplicationService(int id)
        {
            var estudiante = await _baseDatos.Estudiantes.FindAsync(id);
            var respuestaDomainService = _estudianteDomainServices.DeleteEstudianteDomainService(id, estudiante);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Estudiantes.Remove(estudiante);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
