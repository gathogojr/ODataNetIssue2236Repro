using ODataNetIssue2236Repro.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.OData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.ModelBuilder;

namespace ODataNetIssue2236Repro
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.Function("WhoAmI")
                .Returns<User>();

            services.AddControllers()
                .AddOData(options => options.Select().Filter().OrderBy().Count().Expand().SetMaxTop(null)
                .AddRouteComponents("odata", modelBuilder.GetEdmModel()));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseODataRouteDebug();
            app.UseRouting();

            app.UseEndpoints(routeBuilder =>
            {
                routeBuilder.MapControllers();
            });
        }
    }
}
