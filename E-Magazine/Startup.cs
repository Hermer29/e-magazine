using DataAccessFramework;
using DataAccessFramework.Dao.Teachers;
using E_Magazine.Pages;
using EMagazine.UserData;
using EMagazine.UserData.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SqlFacade;

namespace E_Magazine
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
            services.AddRazorPages(options =>
            {
                options.Conventions.AddFolderRouteModelConvention("/", model => { new IndexModel(); });
                options.Conventions.AddFolderRouteModelConvention("/Console", model => { new ConsoleModel(); });
                    options.Conventions.AddFolderRouteModelConvention("/Console/Teacher", model => { new ConsoleModel(); });
            });
            services.AddSingleton<FacadeBuilder>();
            services.AddSingleton<QueryFactorySelector>();
            services.AddSingleton<ConsoleInteractor>();
            services.AddSingleton<UserLoginInteractor>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
