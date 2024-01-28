namespace FilmSearchPortal.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilmController(
	IMapper mapper,
	IFilmService filmService,
	IValidator<FilmViewModel> validator)
	: ControllerBase
{
	[HttpGet("{id}")]
	public async Task<FilmViewModel> Get(Guid id)
	{
		return mapper.Map<FilmViewModel>(await filmService.Get(id));
	}

	[HttpGet("search/{title}")]
	public async Task<FilmViewModel> GetFilmsByName(string title)
	{
		return mapper.Map<FilmViewModel>(await filmService.GetFilmsByTitle(title));
	}

	[HttpGet]
	public async Task<IEnumerable<FilmViewModel>> GetAll()
	{
		return mapper.Map<IEnumerable<FilmViewModel>>(await filmService.GetAll());
	}

	[HttpPost]
	public async Task<FilmViewModel> Create(FilmViewModel model)
	{
		await validator.ValidateAndThrowAsync(model);

		return mapper.Map<FilmViewModel>(
			await filmService.Create(mapper.Map<FilmModel>(model)));
	}

	[HttpPut]
	public async Task<FilmViewModel> Update(FilmViewModel model)
	{
		await validator.ValidateAndThrowAsync(model);

		return mapper.Map<FilmViewModel>(
			await filmService.Update(mapper.Map<FilmModel>(model)));
	}

	[HttpDelete]
	public async Task<FilmViewModel> Delete(Guid id)
	{
		return mapper.Map<FilmViewModel>(await filmService.Delete(id));
	}
}