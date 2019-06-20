using AutoMapper;
using AutoMapper.Configuration;
using LearnInc.Common.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.DependencyInjection;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace LearnInc.Common.Web
{
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
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			// In production, the React files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/build";
			});

			// register types - for now use of build-in DI container - should we change to Unity??
			RegisterTypes(services);

			// to be moved forward later - initialization of mappings
			RegisterMappings();
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
				app.UseExceptionHandler("/Error");
			}

			app.UseStaticFiles();
			app.UseSpaStaticFiles();

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action=Index}/{id?}");
			});

			app.UseSpa(spa =>
			{
				spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment())
				{
					spa.UseReactDevelopmentServer(npmScript: "start");
				}
			});
		}

		public void RegisterTypes(IServiceCollection services)
		{
			services.AddScoped<ITestService, TestService>();

			//IoC.InitializeContainerAndLocator();
			//TypeRegistrar.RegisterTypes(IoC.GlobalContainer);
		}

		public void RegisterMappings()
		{
			MapperConfigurationExpression mapperConfiguration = new MapperConfigurationExpression();

			new MappingRegistrar().RegisterMappings(mapperConfiguration);
			new Services.MappingRegistrar().RegisterMappings(mapperConfiguration);

			Mapper.Initialize(mapperConfiguration);
			Mapper.Configuration.CompileMappings();
		}
	}
}
