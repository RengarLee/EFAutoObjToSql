using EFAutoObjToSql.DbContext;
using EFAutoObjToSql.Log;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EFAutoObjToSql
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Ef Logging
            services.AddDbContext<AppDbContext>
            (o => o.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString"))
                .UseLoggerFactory(GetLoggerFactory()));
        }

        private ILoggerFactory GetLoggerFactory()
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddProvider(new SqlLoggerProvider());
            return loggerFactory;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Create DateBase
            db.Database.EnsureCreated();

            // Delete DateBase
            db.Database.EnsureDeleted();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}