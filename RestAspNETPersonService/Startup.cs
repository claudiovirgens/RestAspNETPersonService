using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RestAspNETPersonService.Context;
using RestAspNETPersonService.Business;
using RestAspNETPersonService.Business.Implementations;
using RestAspNETPersonService.Repository.Implementations;
using RestAspNETPersonService.Repository;
using RestAspNETBookService.Business.Implementations;
using RestAspNETPersonService.Repository.Generic;
using Microsoft.Net.Http.Headers;

namespace RestAspNETPersonService
{
    public class Startup
    {
        public IConfiguration _configuration { get; }
        private readonly ILogger _logger;
        public IHostingEnvironment _environment { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment environment, ILogger<Startup> logger)
        {
            _configuration = configuration;
            _environment = environment;
            _logger = logger;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var connectionString = _configuration["MySQLConnection:MySQLConnectionString"];
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connectionString));
            
            services.AddMvc(options =>
                {
                options.RespectBrowserAcceptHeader = false;
                options.FormatterMappings.SetMediaTypeMappingForFormat("json", MediaTypeHeaderValue.Parse("application/json"));
                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", MediaTypeHeaderValue.Parse("text/xml"));                
                }
            ).SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddXmlSerializerFormatters(); 

            services.AddApiVersioning();

            //Dependency Injection  *********************************
            services.AddScoped<IPersonBusiness, PersonBusinessImpl>();
            services.AddScoped<IPersonRepository, PersonRepositoryImpl>();
            services.AddScoped<IBookBusiness, BookBusinessImpl>();
            //services.AddScoped<IBookRepository, BookRepositoryImpl>();
            
            //Dependency Injection of GenericRepository
            services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
