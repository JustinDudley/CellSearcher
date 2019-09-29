using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CellSearcher.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CellSearcher {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {



            // All but these 4 lines auto-generated.  Create and name the database "Alg927Db" 
            var connStr = @"server=localhost\sqlexpress;database=Alg927Db;trusted_connection=true;";  // Establish connection string
            services.AddDbContext<Alg927DbContext>(option => {
                option.UseSqlServer(connStr);
                // PrsCapstoneDb:  called Proxies on this line, I think
            });



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
