namespace FilmSearchPortal.DAL.Entities;

public class FilmActor : Entity
{
	public Guid? FilmId { get; set; }

	public Film? Film { get; set; }

	public Guid? ActorId { get; set; }

	public Actor? Actor { get; set; }
}
