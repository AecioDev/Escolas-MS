using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscolaMS_Dados.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EscolaMS_Domain.Entities;
using EscolaMS_Web.ViewModels;
using AutoMapper;
using EscolaMS_Domain.Interfaces;
using EscolaMS_Dados.Repositories;
using Microsoft.AspNetCore.Http;

namespace EscolaMS_Web
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
            services.AddControllersWithViews();
            
            services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AlunoViewModel, Aluno>();
                cfg.CreateMap<Aluno, AlunoViewModel>();
                cfg.CreateMap<ResponsavelViewModel, Responsavel>();
                cfg.CreateMap<Responsavel, ResponsavelViewModel>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
            services.AddScoped<IResponsavelRepositorio, ResponsavelRepositorio>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //Session Configuration
            services.AddMemoryCache(); //Guarda os dados na memória
            services.AddSession(options =>
            {
                //options.IdleTimeout //Tempo que o servidor espera antes de finalizar a sessão do usuário.
                //options.IOTimeout //Tempo de espera do servidor pelo cliente 
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        { 
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
