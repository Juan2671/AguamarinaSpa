using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication1.Models.Email;
using WebApplication1.Models;

namespace WebApplication1
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<Usuarios>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<SmtpConfig>(Configuration.GetSection("SmtpConfig"));
            services.AddSingleton<IEmailSenderP, EmailSender>();

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSession(o => o.IdleTimeout = TimeSpan.FromMinutes(60));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
     
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Servi",
                    areaName : "Servi",
                    pattern: "Servi/{controller=Servicio}/{action=IndexDos}/{id?}"
                    );


                endpoints.MapAreaControllerRoute(
                    name: "Productos",
                    areaName: "Productos",
                    pattern: "Productos/{controller=Producto}/{action=IndexDos}/{id?}"
                    );

                endpoints.MapAreaControllerRoute(
                    name: "Categorias",
                    areaName: "Categorias",
                    pattern: "Categorias/{controller=Categoria}/{action=IndexDos}/{id?}"
                    );

                endpoints.MapAreaControllerRoute(
                    name: "Catego",
                    areaName: "Catego",
                    pattern: "Catego/{controller=Categoria}/{action=IndexDos}/{id?}"
                    );

                endpoints.MapAreaControllerRoute(
                   name: "Inicio",
                   areaName: "Inicio",
                   pattern: "Inicio/{controller=Panel}/{action=Index}/{id?}"
                   );

                endpoints.MapAreaControllerRoute(
                   name: "Usu",
                   areaName: "Usu",
                   pattern: "Usu/{controller=Usuario}/{action=IndexDos}/{id?}"
                   );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
