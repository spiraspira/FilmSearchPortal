namespace FilmSearchPortal.DAL.Entities;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
	public DbSet<Actor>? Actors { get; set; }

	public DbSet<Film>? Films { get; set; }

	public DbSet<FilmActor>? FilmActors { get; set; }

	public DbSet<Review>? Reviews { get; set; }
}