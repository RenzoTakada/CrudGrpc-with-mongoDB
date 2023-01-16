using Microsoft.AspNetCore.Mvc;

namespace CRUDGrpcService.Adapters.Http
{
    public static  class Routs
    {
        public static void AddEndpoints(this WebApplication app)
        {
            app.MapGet("Consultar",  IResult ([FromQuery]string value) =>
            {
                return Results.Ok(value);
            });
           
        }

    }
}
