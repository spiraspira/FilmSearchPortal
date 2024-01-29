namespace FilmSearchPortal.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FilmActorController(
	IMapper mapper,
	IGenericService<FilmActorModel> filmActorService)
	: ControllerBase
{
	[HttpGet("{id}")]
	public async Task<FilmActorViewModel> Get(Guid id)
	{
		return mapper.Map<FilmActorViewModel>(await filmActorService.Get(id));
	}

	[HttpGet]
	public async Task<IEnumerable<FilmActorViewModel>> GetAll()
	{
		return mapper.Map<IEnumerable<FilmActorViewModel>>(await filmActorService.GetAll());
	}

	[HttpPost]
	public async Task<FilmActorViewModel> Create(FilmActorViewModel model)
	{
		return mapper.Map<FilmActorViewModel>(
			await filmActorService.Create(mapper.Map<FilmActorModel>(model)));
	}

	[HttpPut]
	public async Task<FilmActorViewModel> Update(FilmActorViewModel model)
	{
		return mapper.Map<FilmActorViewModel>(
			await filmActorService.Update(mapper.Map<FilmActorModel>(model)));
	}

	[HttpDelete]
	public async Task<FilmActorViewModel> Delete(Guid id)
	{
		return mapper.Map<FilmActorViewModel>(await filmActorService.Delete(id));
	}
}