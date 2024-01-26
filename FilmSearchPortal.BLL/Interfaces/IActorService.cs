namespace FilmSearchPortal.BLL.Interfaces;

public interface IActorService : IGenericService<ActorModel>
{
	Task<IEnumerable<ActorModel>> GetActorsByName(string query);
}