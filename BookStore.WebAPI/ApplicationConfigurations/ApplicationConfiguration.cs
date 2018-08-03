using BookStore.Application;
using BookStore.Application.Providers;
using BookStore.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;

namespace BookStore.WebAPI.ApplicationConfigurations
{
   public static class ApplicationConfiguration
   {
      public static void AddMvc(IServiceCollection services)
      {
         services.AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
            .AddJsonOptions(jo =>
            {
               jo.SerializerSettings.ContractResolver = new DefaultContractResolver()
               {
                  NamingStrategy = new SnakeCaseNamingStrategy()
               };

                jo.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

                jo.SerializerSettings.Formatting = Formatting.Indented;
            });
      }

      public static void AddDbContext(IServiceCollection services)
      {
         ServiceProvider serviceProvider = services.BuildServiceProvider();
         IAppSettingsProvider appSettingsProvider = serviceProvider.GetService<IAppSettingsProvider>();

         services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(x => x.UseSqlServer(appSettingsProvider.GetDataBaseConnectionString));
      }

      public static void AddSwaggerGen(IServiceCollection services)
      {
         services.AddSwaggerGen(c =>
         {
            c.SwaggerDoc("v1", new Info() { Version = "v1", Title = "BookStore API" });
         });
      }

      public static void UseSwagger(IApplicationBuilder app)
      {
         app.UseSwagger();
         app.UseSwaggerUI(c =>
         {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "BookStore API V1");
         });
      }
   }
}
