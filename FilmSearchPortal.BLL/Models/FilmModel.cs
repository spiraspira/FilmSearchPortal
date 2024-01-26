namespace FilmSearchPortal.BLL.Models;

public class FilmModel : Model
{
	public string? Title { get; set; }

	public string? Description { get; set; }

	public int? ReleaseYear { get; set; }

	public TimeSpan Duration { get; set; }

	public List<FilmActorModel> FilmActors { get; set; } = [];

	public List<ReviewModel> Reviews { get; set; } = [];
}