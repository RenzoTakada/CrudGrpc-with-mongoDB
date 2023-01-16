using CRUDGrpcService.Adapters.MongoDB.Extensions;
using CRUDGrpcService.Application.Routs;
using CRUDGrpcService.Application.UserCase.ConsultarUSC;
using CRUDGrpcService.Application.UserCase.DeletarUSC;
using CRUDGrpcService.Application.UserCase.RegistrarUSC;
using CRUDGrpcService.Extensions;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGrpc();
builder.Services.AddMongoDB();
builder.Services.AddScoped<IUSCRegistrar, USCRegistrar>();
builder.Services.AddScoped<IUSCConsultar, USCConsultar>();
builder.Services.AddScoped<IUSCDeletar, USCDeletar>();
//builder.Host.ConfigureWebHostDefaults(webBuilder =>
// webBuilder.ConfigureKestrel(options =>
// {
//     options.ListenAnyIP(5001, o => o.Protocols = HttpProtocols.Http1);
//     options.ListenAnyIP(5002, o => o.Protocols = HttpProtocols.Http2);
// })
//);

//Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
//{
//  webBuilder.ConfigureKestrel(options =>
//  {
//      options.ListenAnyIP(5001, o => o.Protocols = HttpProtocols.Http1);
//      options.ListenAnyIP(5002, o => o.Protocols = HttpProtocols.Http2);
//  });
//  webBuilder.ConfigureServices(services => services.AddGrpc());
//  webBuilder.UseStartup<Startup>();


//});
//var startup = new Startup(builder.Configuration);

//startup.ConfigureServices(builder.Services);

var app = builder.Build();

//startup.Configure(app, app.Environment);
//app.MapSwagger();
app.AddRouts();
app.Run();

