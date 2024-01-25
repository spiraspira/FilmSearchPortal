namespace FilmSearchPortal.DAL.Repositories;

public class ActorRepository(ApplicationDbContext context) : GenericRepository<Actor>(context), IActorRepository
{
	public async Task<IEnumerable<Actor>> GetActorsByName(string query)
	{
		return await Set
			.Where(actor => actor.FirstName != null &&
							actor.LastName != null &&
							string.Concat(actor.FirstName, " ", actor.LastName).Contains(query))
			.ToListAsync();
	}

	public override Task<Actor?> Get(Guid id)
	{
		return Set
			.Include(film => film.FilmActors)
			.ThenInclude(filmActor => filmActor.Film)
			.FirstOrDefaultAsync(film => film.Id == id);
	}
}