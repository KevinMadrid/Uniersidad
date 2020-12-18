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
    public class PaisAppService
    {
        private readonly UniversidadDataContext _baseDatos;
        private readonly PaisDomainService _paisDomainServices;

        public PaisAppService(UniversidadDataContext _context, PaisDomainService paisDomainService)
        {
            _baseDatos = _context;
            _paisDomainServices = paisDomainService;
        }

        public async Task<String> GetPaisApplicationService(int id)
        {
            var pais = await _baseDatos.Pais.FirstOrDefaultAsync(q => q.Id == id);


            var respuestaDomainService = _paisDomainServices.GetPaisDomainService(id, pais);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }
            return null;
        }
        public async Task<String> PostPaisApplicationService(Pais pais)
        {
            var respuestaDomainService = _paisDomainServices.PostPaisDomainService(pais);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Pais.Add(pais);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
       
        public async Task<String> PutPaisApplicationService(int id, Pais pais)
        {

            var respuestaDomainService = _paisDomainServices.PutPaisDomainService(id, pais);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Entry(pais).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();

            return null;
        }
        public async Task<String> DeletPaisApplicationService(int id)
        {
            var pais = await _baseDatos.Pais.FindAsync(id);
            var respuestaDomainService = _paisDomainServices.DeletePaisDomainService(id, pais);

            bool hayErrorEnElDomainService = respuestaDomainService != null;
            if (hayErrorEnElDomainService)
            {
                return respuestaDomainService;
            }

            _baseDatos.Pais.Remove(pais);
            await _baseDatos.SaveChangesAsync();

            return null;
        }
    }
    }
