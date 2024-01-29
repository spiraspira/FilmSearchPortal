namespace FilmSearchPortal.BLL.DI;

public static class BusinessLogicRegister
{
	public static void AddBusinessLogic(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped<IActorService, ActorService>();

		services.AddScoped<IFilmService, FilmService>();

		services.AddScoped<IGenericService<ReviewModel>, GenericService<ReviewModel, Review>>();

		services.AddScoped<IGenericService<FilmActorModel>, GenericService<FilmActorModel, FilmActor>>();

		services.AddDataAccess(config);
	}
}