using BookStore.Persistance.Dependency;
using BookStore.WebAPI.ApplicationConfigurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.WebAPI
{
   public class Startup
   {
      public Startup(IHostingEnvironment env)
      {
         this.Configuration = new ConfigurationBuilder()
         .SetBasePath(env.ContentRootPath)
         .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
         .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
         .AddEnvironmentVariables()
         .Build();
      }

      public IConfiguration Configuration { get; }

      public void ConfigureServices(IServiceCollection services)
      {
         DependencyResolver.SetDependencies(services, this.Configuration);

         ApplicationConfiguration.AddMvc(services);
         ApplicationConfiguration.AddDbContext(services);
         ApplicationConfiguration.AddSwaggerGen(services);
      }

      public void Configure(IApplicationBuilder app, IHostingEnvironment env)
      {
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
         }
         else
         {
            app.UseHsts();
         }

         ApplicationConfiguration.UseSwagger(app);

         app.UseHttpsRedirection();
         app.UseMvc();
      }
   }
}
