using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADUM.Repository;
using ADUM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using ADUM.Controllers;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ADUM
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            //Configuration = configuration;
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            services.AddControllersWithViews();
            services.AddScoped<ITokenRepository, TokenRepository>();
            services.AddScoped<IAddRepository, AddRepository>();
            //services.Configure<LdapConfig>(Configuration.GetSection("ldap"));
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            /*
            // default access requires admin access
            var isAdminUserPolicy = new AuthorizationPolicyBuilder().RequireRole("Admin").Build();
            services.AddMvc(options =>
            {
                options.Filters.Add(new ApplyPolicyOrAuthorizeFilter(isAdminUserPolicy));
            });
            */

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

            /*
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                Events = new CookieAuthenticationEvents
                {
                    // You will need this only if you use Ajax calls with a library not compatible with IsAjaxRequest
                    // More info here: https://github.com/aspnet/Security/issues/1056
                    OnRedirectToAccessDenied = context =>
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                        return TaskCache.CompletedTask;
                    }
                },
                AuthenticationScheme = "app",
                LoginPath = new PathString("/login"),
                AutomaticAuthenticate = true,
                AutomaticChallenge = true
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "login",
                    template: "login",
                    defaults: new { controller = "Account", action = "Login" }
                );
                routes.MapRoute(
                    name: "logout",
                    template: "logout",
                    defaults: new { controller = "Account", action = "Logout" }
                );
            });

            */


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
