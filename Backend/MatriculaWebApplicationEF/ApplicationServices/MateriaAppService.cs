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
    public class MateriaAppService
    {
        private readonly UniversidadDataContext _baseDatos;
        private readonly MateriaDomainService _materiaDomainServices;

        public MateriaAppService(UniversidadDataContext _context, MateriaDomainService materiaDomainService)
        {
            _baseDatos = _context;
            _materiaDomainServices = materiaDomainService;
        }

        public async Task<String> GetMateriaApplicationService(int id)
        {
            var materia = await _baseDatos.Materias.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _materiaDomainServices.GetMateriaDomainService(id, materia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostMateriaApplicationService(Materia materia)
        {
            var respuestaDomainService = _materiaDomainServices.PostMateriaDomainService(materia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Materias.Add(materia);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
       
        public async Task<String> PutMateriaApplicationService(int id, Materia materia)
        {

            var respuestaDomainService = _materiaDomainServices.PutMateriaDomainService(id, materia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(materia).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletArticulosApplicationService(int id)
        {
            var materia = await _baseDatos.Materias.FindAsync(id);
            var respuestaDomainService = _materiaDomainServices.DeleteMateriaDomainService(id, materia);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Materias.Remove(materia);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
