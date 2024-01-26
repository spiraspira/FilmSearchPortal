using FilmSearchPortal.BLL.Services;
using FilmSearchPortal.DAL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilmSearchPortal.BLL.DI;

public static class BusinessLogicRegister
{
	public static void AddBusinessLogic(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped<IActorService, ActorService>();

		services.AddScoped<IFilmService, FilmService>();

		services.AddDataAccess(config);
	}
}