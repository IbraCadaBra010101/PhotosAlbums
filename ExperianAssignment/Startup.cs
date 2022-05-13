using ExperianAssignment.Repository;
using ExperianAssignment.Repository.Implementation;
using ExperianAssignment.Services;
using ExperianAssignment.Services.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace ExperianAssignment
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
            services.AddScoped<ICombinedCollectionRepository, CombinedCollectionRepository>();
            services.AddSingleton<IDataContextService, DataContextService>();
            services.AddHttpClient("DataContextService", c => c.BaseAddress = new Uri("http://jsonplaceholder.typicode.com/"));
         
            
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
