namespace FilmSearchPortal.BLL.Interfaces;

public interface IFilmService : IGenericService<FilmModel>
{
	Task<IEnumerable<FilmModel>> GetFilmsByTitle(string query);
}