namespace FilmSearchPortal.BLL.Services;

public class FilmService : GenericService<FilmModel, Film>, IFilmService
{
	private readonly IFilmRepository _repository;

	private readonly IMapper _mapper;

	public FilmService(IFilmRepository repository, IMapper mapper) : base(repository, mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<IEnumerable<FilmModel>> GetFilmsByTitle(string query)
	{
		var entities = await _repository.GetFilmsByTitle(query);

		return _mapper.Map<IEnumerable<FilmModel>>(entities);
	}
}