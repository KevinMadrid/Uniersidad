﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MatriculaWebApplicationEF.ApplicationServices;
using MatriculaWebApplicationEF.DataContext;
using MatriculaWebApplicationEF.DomainServices;

namespace MatriculaWebApplicationEF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<EstudianteDomainService>();
            services.AddScoped<EstudianteAppService>();
            services.AddScoped<CursoDomainService>();
            services.AddScoped<CursoAppService>();
            services.AddScoped<PaisDomainService>();
            services.AddScoped<PaisAppService>();
            services.AddScoped<MateriaDomainService>();
            services.AddScoped<MateriaAppService>();
            services.AddScoped<ProfesorDomainService>();
            services.AddScoped<ProfesorAppService>();
            services.AddScoped<UsuarioDomainService>();
            services.AddScoped<UsuarioAppService>();
            services.AddDbContext<UniversidadDataContext>();
            
            services.AddMvc().AddNewtonsoftJson(option => option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
