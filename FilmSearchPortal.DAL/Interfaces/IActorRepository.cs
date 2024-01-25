namespace FilmSearchPortal.DAL.Interfaces;

public interface IActorRepository : IGenericRepository<Actor>
{
	Task<IEnumerable<Actor>> GetActorsByName(string query);
}