using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace ExamTesting_FrontEnd
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



            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();

            // Add framework services.
            services
                .AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());


            services.AddDbContext<ExamTestingDbContext>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "admin/{controller=Home}/{action=Index}/{id?}",
                  new { area = "admin" }
                );
            });


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "Default",
                  template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
