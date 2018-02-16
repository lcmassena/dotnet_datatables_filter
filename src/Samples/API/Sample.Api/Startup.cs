using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sample.Api.Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace Sample.Api
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
            var swaggerInfo = new Info
            {
                Version = "v1",
                Title = "DataTables Filter API",
                Description = "API documentation for Dotnet DataTables Filter",
                Contact = new Contact { Name = "Lucas Massena", Email = "lucas@massena.com.br", Url = "http://www.massena.com.br" },
            };

            services.AddSingleton(typeof(ICityRepository), typeof(CityRepository));

            services
                .AddSwaggerGen(s => s.SwaggerDoc(swaggerInfo.Version, swaggerInfo));

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseSwagger()
                .UseSwaggerUI(s => s.SwaggerEndpoint("/swagger/v1/swagger.json", "Dotnet DataTables Filter API v1.0"))
                .UseMvc();
        }
    }
}
