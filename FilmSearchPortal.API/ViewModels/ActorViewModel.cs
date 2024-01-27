namespace FilmSearchPortal.API.ViewModels;

public class ActorViewModel
{
	public Guid Id { get; set; }

	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public DateTime DateOfBirth { get; set; }

	public string? Biography { get; set; }
}
