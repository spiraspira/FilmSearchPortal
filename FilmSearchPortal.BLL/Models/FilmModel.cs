namespace FilmSearchPortal.BLL.Models;

public class FilmModel
{
	public Guid? Id { get; set; }

	public string? Title { get; set; }

	public string? Description { get; set; }

	public int? ReleaseYear { get; set; }

	public TimeSpan Duration { get; set; }
}