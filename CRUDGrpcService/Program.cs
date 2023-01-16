using CRUDGrpcService.Adapters.Http;
using CRUDGrpcService.Adapters.MongoDB.Extensions;
using CRUDGrpcService.Application.Routs;
using CRUDGrpcService.Application.UserCase.ConsultarUSC;
using CRUDGrpcService.Application.UserCase.DeletarUSC;
using CRUDGrpcService.Application.UserCase.RegistrarUSC;

using Microsoft.AspNetCore.Server.Kestrel.Core;
using W3PIXHUBConsentimento.Extensions;


    var builder = WebApplication.CreateBuilder(args);

    builder.WebHost.ConfigureKestrel(options =>
    {
        options.ListenAnyIP(8086, o => o.Protocols = HttpProtocols.Http1);
        options.ListenAnyIP(8088, o => o.Protocols = HttpProtocols.Http2);
    });

          builder.Services.AddControllers();
          builder.Services.AddGrpc();
          builder.Services.AddMongoDB();
          builder.Services.AddSwaggerConfigs();
          builder.Services.AddScoped<IUSCRegistrar, USCRegistrar>();
          builder.Services.AddScoped<IUSCConsultar, USCConsultar>();
          builder.Services.AddScoped<IUSCDeletar, USCDeletar>();


          var app = builder.Build();

          app.UseRouting();
          //app.UseAuthentication();
          //app.UseAuthorization();
          app.MapGrpcService<ServiceConsultar>();
          app.MapGrpcService<ServiceRegistar>();
          app.MapGrpcService<ServiceDeletar>();
          app.MapGrpcService<SeriviceAtualizar>();
          app.AddEndpoints();
        
          app.MapSwagger();
          app.Run();
    