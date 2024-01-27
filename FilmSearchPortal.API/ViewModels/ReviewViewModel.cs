namespace FilmSearchPortal.API.ViewModels;

public class ReviewViewModel
{
	public Guid Id { get; set; }

	public string? Title { get; set; }

	public string? Description { get; set; }

	public int? Rate { get; set; }

	public Guid? FilmId { get; set; }

	public FilmViewModel? Film { get; set; }
}
