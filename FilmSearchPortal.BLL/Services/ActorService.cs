namespace FilmSearchPortal.BLL.Services;

public class ActorService : GenericService<ActorModel, Actor>, IActorService
{
	private readonly IActorRepository _repository;

	private readonly IMapper _mapper;

	public ActorService(IActorRepository repository, IMapper mapper) : base(repository, mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<IEnumerable<ActorModel>> GetActorsByName(string query)
	{
		var entities = await _repository.GetActorsByName(query);

		return _mapper.Map<IEnumerable<ActorModel>>(entities);
	}
}