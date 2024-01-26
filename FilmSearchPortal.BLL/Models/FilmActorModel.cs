namespace FilmSearchPortal.BLL.Models;

public class FilmActorModel : Model
{
	public Guid? FilmId { get; set; }

	public FilmModel? Film { get; set; }

	public Guid? ActorId { get; set; }

	public ActorModel? Actor { get; set; }
}