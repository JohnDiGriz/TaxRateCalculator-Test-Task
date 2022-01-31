using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using TestTask.Core.Interfaces;
using TestTask.Core.Models;
using TestTask.DAL;
using TestTask.DAL.Repositories;
using TestTask.DAL.Services;
using TestTask.Middleware;

namespace TestTask
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
            services.AddControllers();
            services.AddDbContext<TaxContext>(options => options.UseSqlServer(Configuration.GetConnectionString("TaxContext")));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IFeeRepository, FeeRepository>();
            services.AddTransient<ITaxRepository, TaxRepository>();
            services.AddTransient<IRepository<State>, Repository<State>>();
            services.AddTransient<IRepository<Vehicle>, Repository<Vehicle>>();
            services.AddTransient<ITaxCalculationService, TaxCalculationSevice>();
            services.AddSingleton(Log.Logger);
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("log.txt", shared: true)
                .CreateLogger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseMiddleware<LoggingMiddleware>();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
