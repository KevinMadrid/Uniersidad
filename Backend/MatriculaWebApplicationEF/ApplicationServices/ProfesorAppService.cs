using MatriculaWebApplicationEF.DataContext;
using MatriculaWebApplicationEF.DomainServices;
using Microsoft.EntityFrameworkCore;
using MatriculaWebApplicationEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatriculaWebApplicationEF.ApplicationServices
{
    public class ProfesorAppService
    {
        private readonly UniversidadDataContext _baseDatos;
        private readonly ProfesorDomainService _profesorDomainServices;

        public ProfesorAppService(UniversidadDataContext _context, ProfesorDomainService profesorDomainService)
        {
            _baseDatos = _context;
            _profesorDomainServices = profesorDomainService;
        }

        public async Task<String> GetProfesorApplicationService(int id)
        {
            var profesor = await _baseDatos.Profesors.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _profesorDomainServices.GetProfesorDomainService(id, profesor);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostProfesorApplicationService(Profesor profesor)
        {
            var respuestaDomainService = _profesorDomainServices.PostProfesorDomainService(profesor);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Profesors.Add(profesor);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
       
        public async Task<String> PutProfesorApplicationService(int id, Profesor profesor)
        {

            var respuestaDomainService = _profesorDomainServices.PutProfesorDomainService(id, profesor);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(profesor).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletProfesorApplicationService(int id)
        {
            var profesor = await _baseDatos.Profesors.FindAsync(id);
            var respuestaDomainService = _profesorDomainServices.DeleteProfesorDomainService(id, profesor);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Profesors.Remove(profesor);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
