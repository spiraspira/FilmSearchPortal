namespace FilmSearchPortal.DAL.Entities;

public class Review : Entity
{
	public string? Title { get; set; }

	public string? Description { get; set; }

	public int? Rate { get; set; }

	public Guid? FilmId { get; set; }

	public Film? Film { get; set; }
}
