using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebServices.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace WebServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ModelContext>(options => options.UseSqlServer(connection));
            services.AddScoped<ModelContext>();
            services.AddMvc();
            var optionsBuilder = new DbContextOptionsBuilder<ModelContext>();
            optionsBuilder.UseSqlServer(connection);
            using (var item = new ModelContext(optionsBuilder.Options))
            {
                UserTable user = new UserTable() { FirstName = "wqe", AcountNumber = 4, DOB = DateTime.Now, Email = "wqq", GroupName = "qeqw", LastName = "eqwe", Password = "qweq" };
                item.UserTable.Add(user);
                item.SaveChanges();

            }
        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
