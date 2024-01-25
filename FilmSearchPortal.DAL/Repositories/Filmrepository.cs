namespace FilmSearchPortal.DAL.Repositories;

public class FilmRepository(ApplicationDbContext context) : GenericRepository<Film>(context), IFilmRepository
{
	public async Task<IEnumerable<Film>> GetFilmsByTitle(string query)
	{
		return await Set
			.Where(film => film.Title != null && film.Title.Contains(query))
			.ToListAsync();
	}
}