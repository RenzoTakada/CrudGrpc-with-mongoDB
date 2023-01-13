using CRUDGrpcService.Adapters.MongoDB.Extensions;
using CRUDGrpcService.Application.Routs;
using CRUDGrpcService.Application.UserCase.ConsultarUSC;
using CRUDGrpcService.Application.UserCase.DeletarUSC;
using CRUDGrpcService.Application.UserCase.RegistrarUSC;
using CRUDGrpcService.Extensions;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureWebHostDefaults(webBuilder =>
{
    webBuilder.ConfigureKestrel(options =>
    {
        options.ListenAnyIP(5001, o => o.Protocols = HttpProtocols.Http1);
        options.ListenAnyIP(5002, o => o.Protocols = HttpProtocols.Http2);
    });

    webBuilder.UseStartup<Startup>();
});
var app = builder.Build();

app.AddRouts();
app.Run();
