﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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
            //services.AddMvc();
            string connection = Configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<TableOfStatementsContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<UserTableContext>(options => options.UseSqlServer(connection));
            //services.AddDbContext<Model>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();

            services.AddDbContext<Model>(options => options.UseSqlServer(Configuration.GetConnectionString(name: "CustomConnection"))
              .EnableSensitiveDataLogging());

            using (var item = new Model())
            {
                UserTable user = new UserTable() { AcountNumber = 1, DOB = DateTime.Now, Email = "fgdfg",
                    FirstName = "sfd", GroupName = "sdfg", LastName = "dfg", Password = "udfgdfg" };
                item.UserTables.Add(user);
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
