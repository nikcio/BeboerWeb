using BeboerWeb.Api.Application.Services;
using BeboerWeb.Api.Persistence.Contexts;
using BeboerWeb.Api.Persistence.Repositories;
using BeboerWeb.Shared.Persistence.UnitOfWorks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Threading.Tasks;

namespace BeboerWeb.Api
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
            services.AddAutoMapper(typeof(Startup).Assembly);

            services.AddDbContext<ApiDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IApiDbContext, ApiDbContext>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.CustomOperationIds(e => $"API_{e.ActionDescriptor.RouteValues["action"]}{e.ActionDescriptor.RouteValues["controller"]}");
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BeboerWeb.Api", Version = "v1" });
            });

            services.AddApiRepositories();
            services.AddApiServices();
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BeboerWeb.Api v1"));

                app.UseRouter(builder =>
                {
                    builder.MapGet("", context =>
                    {
                        context.Response.Redirect("./swagger/index.html", permanent: false);
                        return Task.FromResult(0);
                    });
                });
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
