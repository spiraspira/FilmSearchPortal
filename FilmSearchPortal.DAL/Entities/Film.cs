namespace FilmSearchPortal.DAL.Entities;

public class Film : Entity
{
	public string? Title { get; set; }

	public string? Description { get; set; }

	public int? ReleaseYear { get; set; }

	public TimeSpan Duration { get; set; }

	public List<FilmActor> FilmActors { get; set; } = [];

	public List<Review> Reviews { get; set; } = [];
}
