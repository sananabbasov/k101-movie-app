using System;
using K101MovieApp.Business.Abstract;
using K101MovieApp.Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace K101MovieApp.Business.DependencyResolvers.OwnDependency
{
	public static class DependencyCreater
	{
		public static void CreateScopeds(this IServiceCollection services)
		{
            services.AddScoped<IFilmService, FilmManager>();
        }
	}
}

