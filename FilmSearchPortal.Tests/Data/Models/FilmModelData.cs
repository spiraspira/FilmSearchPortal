namespace FilmSearchPortal.Tests.Data.Models;

public static class FilmModelData
{
	public static FilmModel InitFilmModel()
	{
		var film = new FilmModel
		{
			Id = Guid.NewGuid(),
			Title = "Test"
		};

		return film;
	}

	public static List<FilmModel> InitFilmModelCollection()
	{
		return [InitFilmModel()];
	}
}