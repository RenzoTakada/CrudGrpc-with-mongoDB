using CRUDGrpcService.Adapters.MongoDB.Extensions;
using CRUDGrpcService.Application.Routs;
using CRUDGrpcService.Application.UserCase.ConsultarUSC;
using CRUDGrpcService.Application.UserCase.DeletarUSC;
using CRUDGrpcService.Application.UserCase.RegistrarUSC;
using Extensions;
using Microsoft.AspNetCore.Builder;

namespace CRUDGrpcService.Extensions
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddGrpc();
            services.AddMongoDB();
            services.AddScoped<IUSCRegistrar, USCRegistrar>();
            services.AddScoped<IUSCConsultar, USCConsultar>();
            services.AddScoped<IUSCDeletar, USCDeletar>();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerConfigs();
            services.AddSwaggerGen();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();


                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
         
        }
    }
}
