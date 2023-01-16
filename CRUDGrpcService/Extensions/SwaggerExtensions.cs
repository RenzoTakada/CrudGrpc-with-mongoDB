
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwaggerConfigs(this IServiceCollection services)
        {

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
              
                c.OperationFilter<AddRequiredHeaderParameter>();

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "1.0.0",
                    Title = "Api Bloqueio Saldo",
                    Description = "Api de Bloqueio saldo  ",
                    
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Email ="renzo.takada@w3as.com.br",
                    }
                    

                });



            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."

                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                                {
                                    {
                                        new OpenApiSecurityScheme
                                            {
                                                Reference = new OpenApiReference
                                                {
                                                    Type = ReferenceType.SecurityScheme,
                                                    Id = "Bearer"
                                                }
                                            },
                                            new string[] {}

                                    }
                                });

            });
            #endregion

            return services;
        }


        public static WebApplication MapSwagger(this WebApplication app)
        {
            if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName == "Fabrica")
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }





            app.UseHttpsRedirection();

            return app;
        }
    }
    public class AddRequiredHeaderParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "chaveIdempotencia",
                In = ParameterLocation.Header,
                Required = false
            });
        }

    }

}
