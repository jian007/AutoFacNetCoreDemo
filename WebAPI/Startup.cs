using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
//using LinqToDB.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
           
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            //IServiceProvider
    
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //DataConnection.DefaultSettings = new MySettings();

            var builder = new ContainerBuilder();

            var controlasse = Assembly.Load("WebAPI");
            builder.RegisterAssemblyTypes(controlasse);
            string basePath2 = Path.GetDirectoryName(typeof(Program).Assembly.Location);

            var dal = Assembly.LoadFile(basePath2 + @"\Repository.DAL.dll");
            var idal = Assembly.Load("Repository.IDAL");
          // string sqlConnectionString ="server=127.0.0.1;userid=root;password=root;port=3306;database=autofacdemo;allowPublicKeyRetrieval=true;Character Set=utf8";
           // services.AddDbContext<BaseDbContex>(options => options.UseMySql(sqlConnectionString));

            builder.RegisterAssemblyTypes(dal, idal).AsImplementedInterfaces();

            builder.Populate(services);

            this.ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(ApplicationContainer);


            //sql server
            //services.AddDbContextPool<EntityPoolDBContext>(options => options.UseSqlServer("your DB connection address"));
            //mysql
      


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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
