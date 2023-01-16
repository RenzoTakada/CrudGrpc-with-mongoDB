using Microsoft.OpenApi.Models;

namespace W3PIXHUBConsentimento.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwaggerConfigs(this IServiceCollection services)
        {

            #region Swagger
            services.AddSwaggerGen();
            //{

            //    //c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //    //{
            //    //    Name = "Authorization",
            //    //    Type = SecuritySchemeType.ApiKey,
            //    //    Scheme = "Bearer",
            //    //    BearerFormat = "JWT",
            //    //    In = ParameterLocation.Header,
            //    //    Description = "JWT Authorization header using the Bearer scheme."

            //    //});

            //    //c.AddSecurityRequirement(new OpenApiSecurityRequirement
            //    //                {
            //    //                    {
            //    //                        new OpenApiSecurityScheme
            //    //                            {
            //    //                                Reference = new OpenApiReference
            //    //                                {
            //    //                                    Type = ReferenceType.SecurityScheme,
            //    //                                    Id = "Bearer"
            //    //                                }
            //    //                            },
            //    //                            new string[] {}

            //    //                    }
            //    //                });

            //});
            #endregion

            return services;
        }


        public static WebApplication MapSwagger(this WebApplication app)
        {
            //if (app.Environment.IsDevelopment() || app.Environment.EnvironmentName == "Fabrica")
            //{
                app.UseSwagger();
                app.UseSwaggerUI();
            //}
     
            app.MapControllers();


            return app;
        }
    }

}
