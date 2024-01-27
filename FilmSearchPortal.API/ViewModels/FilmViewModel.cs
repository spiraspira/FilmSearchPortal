namespace FilmSearchPortal.API.ViewModels;

public class FilmViewModel
{
	public Guid Id { get; set; }

	public string? Title { get; set; }

	public string? Description { get; set; }

	public int? ReleaseYear { get; set; }

	public TimeSpan Duration { get; set; }

	public List<FilmActorViewModel> FilmActors { get; set; } = [];
}
