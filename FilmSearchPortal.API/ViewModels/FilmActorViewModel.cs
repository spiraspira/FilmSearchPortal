namespace FilmSearchPortal.API.ViewModels;

public class FilmActorViewModel
{
	public Guid Id { get; set; }

	public Guid? FilmId { get; set; }

	public FilmViewModel? Film { get; set; }

	public Guid? ActorId { get; set; }

	public ActorViewModel? Actor { get; set; }
}
