namespace FilmSearchPortal.BLL.Models;

public class FilmActorModel
{
	public Guid? Id { get; set; }

	public Guid? FilmId { get; set; }

	public FilmModel? Film { get; set; }

	public Guid? ActorId { get; set; }

	public ActorModel? Actor { get; set; }
}