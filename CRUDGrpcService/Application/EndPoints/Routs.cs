
namespace CRUDGrpcService.Application.Routs
{
    public static class Routs
    {
        public static WebApplication AddRouts(this WebApplication app)
        {
            app.MapGrpcService<ServiceConsultar>();
            app.MapGrpcService<ServiceRegistar>();
            app.MapGrpcService<ServiceDeletar>();
            app.MapGrpcService<SeriviceAtualizar>();

            return app;
        }
    }
}
