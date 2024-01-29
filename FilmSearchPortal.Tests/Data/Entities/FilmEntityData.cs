namespace FilmSearchPortal.Tests.Data.Entities;

public static class FilmEntityData
{
	public static Film InitFilmEntity()
	{
		var film = new Film
		{
			Id = Guid.NewGuid(),
			Title = "Test"
		};

		return film;
	}

	public static List<Film> InitFilmEntityCollection()
	{
		return [InitFilmEntity()];
	}
}