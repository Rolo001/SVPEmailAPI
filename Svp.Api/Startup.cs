namespace Svp.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Svp.Data.Classes;
    using Svp.Data.Classes.CommandFactory;
    using Svp.Data.Interfaces;
    using Svp.Services.Classes;
    using Svp.Services.Interfaces;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserGateway, UserGateway>();
            services.AddScoped<IConnectionStringProvider, ConnectionStringProvider>();
            services.AddScoped<IUserSqlCommandFactory, UserSqlCommandFactory>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                //SSL: create your business logic on a secified folder.
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
