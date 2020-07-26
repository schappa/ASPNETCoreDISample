using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCoreDISample.Contracts;
using ASPNETCoreDISample.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETCoreDISample
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.Add(new ServiceDescriptor(typeof(IBooksRepository), typeof(InMemoryBooksRepository)));

            //services.Add(new ServiceDescriptor(typeof(IBooksRepository), typeof(InMemoryBooksRepository), ServiceLifetime.Singleton));
            //services.Add(new ServiceDescriptor(typeof(IBooksRepository), typeof(InMemoryBooksRepository), ServiceLifetime.Scoped));
            //services.Add(new ServiceDescriptor(typeof(IBooksRepository), typeof(InMemoryBooksRepository), ServiceLifetime.Transient));

            
            //services.AddScoped<IBooksRepository, InMemoryBooksRepository>();
            //services.AddSingleton<IBooksRepository, InMemoryBooksRepository>();


            services.AddTransient<IBooksRepository, InMemoryBooksRepository>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
