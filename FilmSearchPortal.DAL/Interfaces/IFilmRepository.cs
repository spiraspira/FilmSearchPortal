namespace FilmSearchPortal.DAL.Interfaces;

public interface IFilmRepository : IGenericRepository<Film>
{
	Task<IEnumerable<Film>> GetFilmsByTitle(string query);
}