using BeboerWeb.Mvc.Integrations;
using BeboerWeb.Mvc.Persistence.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using BeboerWeb.Mvc.Authorization.Constants;

namespace BeboerWeb.Mvc
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

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddHttpClient();
            services.AddScoped(client =>
            {
                var httpclient = client.GetRequiredService<IHttpClientFactory>().CreateClient();
                return new ApiClient(Configuration.GetValue<string>("Clients:Api:BaseUrl"), httpclient);
            });

            services.AddAuthorization(options =>
            {
                options.FallbackPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                AddPolicies(options);
            });
        }

        private static void AddPolicies(AuthorizationOptions options)
        {
            options.AddPolicy(Policies.EmployeeOnly, policy =>
            {
                policy.RequireClaim(Claims.Employee);
            });

            options.AddPolicy(Policies.ActiveTenantOnly, policy =>
            {
                policy.RequireClaim(Claims.ActiveTenant);
            });

            options.AddPolicy(Policies.InActiveTenantOnly, policy =>
            {
                policy.RequireClaim(Claims.InActiveTenant);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Security NWebsec package
            app.UseXfo(options => options.Deny());
            app.UseXContentTypeOptions();
            app.UseHsts(options => options.MaxAge(days: 30));
            app.UseXXssProtection(options => options.EnabledWithBlockMode());

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
