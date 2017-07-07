using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Validation.Models;
using Microsoft.Data.Entity;
using Microsoft.Extensions.PlatformAbstractions;


namespace Validation
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddEntityFramework()
                    .AddSqlServer()
                    .AddDbContext<EmployeeDbContext>(options =>
                    {
                        options.UseSqlServer(Configuration.Get<string>("Data:DefaultConnection:ConnectionString"));
                    });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseIISPlatformHandler();

            app.UseMvc();
            app.UseMvc(routes =>
            {

                //routes.MapRoute(
                //    name: "FirstRoute",
                //    template: "Hello",
                //    defaults: new { controller = "Home", action = "Index2" }
                //    );


                routes.MapRoute(
                    name: "default",
                    template: "{controller=Employee}/{action=Index}/{id?}");
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
