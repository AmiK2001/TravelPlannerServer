using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using TravelPlannerServer.Models;
using TravelPlannerServer.Services;

namespace TravelPlannerServer
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
            services.Configure<TravelPlannerDatabaseSettings>(
                Configuration.GetSection(nameof(TravelPlannerDatabaseSettings)));

            services.AddSingleton<ITravelPlannerDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<TravelPlannerDatabaseSettings>>().Value);
            
            services.AddTransient<UserService>();
            
            services.AddControllers();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}