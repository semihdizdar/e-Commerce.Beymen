using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Stock.Core.Model;
using Stock.Core.Repositories;
using Stock.Core.Services;
using Stock.Core.UnitOfWorks;
using Stock.Repository;
using Stock.Repository.Repositories;
using Stock.Repository.UnitOfWorks;
using Stock.Service.Mapping;
using Stock.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Stock.Web.Api
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

            services.AddDbContext<AppDbContext>(x =>
               x.UseSqlServer(Configuration.GetConnectionString("SqlConnection"), option =>
               {
                   option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
               }
               ));


            //services.AddControllers();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<IVariantRepository, VariantRepository>();
            services.AddScoped<IVariantService<Variant>, VariantService<Variant>>();
            services.AddScoped<IStockService<StockInfo>, StockInfoService<StockInfo>>();
            services.AddScoped<IStockRepository, StockRepository>();

            services.AddAutoMapper(typeof(MapProfile));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "1.0.0",
                    Title = "Stock API",
                    Description = "Api Swagger Documentation",
                    Contact = new OpenApiContact
                    {
                        Name = "Semih DÝZDAR"

                    }
                });
            });



            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Stock API v1");
                    c.RoutePrefix = string.Empty;
                });
            }



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
