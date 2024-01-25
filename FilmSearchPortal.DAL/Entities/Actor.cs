namespace FilmSearchPortal.DAL.Entities;

public class Actor : Entity
{
	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public DateTime DateOfBirth { get; set; }

	public string? Biography { get; set; }

	public List<FilmActor> FilmActors { get; set; } = [];
}
