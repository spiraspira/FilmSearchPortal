namespace FilmSearchPortal.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorController(
	IMapper mapper,
	IActorService actorService,
	IValidator<ActorViewModel> validator)
	: ControllerBase
{
	[HttpGet("{id}")]
	public async Task<ActorViewModel> Get(Guid id)
	{
		return mapper.Map<ActorViewModel>(await actorService.Get(id));
	}

	[HttpGet("search/{name}")]
	public async Task<ActorViewModel> GetActorsByName(string name)
	{
		return mapper.Map<ActorViewModel>(await actorService.GetActorsByName(name));
	}

	[HttpGet]
	public async Task<IEnumerable<ActorViewModel>> GetAll()
	{
		return mapper.Map<IEnumerable<ActorViewModel>>(await actorService.GetAll());
	}

	[HttpPost]
	public async Task<ActorViewModel> Create(ActorViewModel model)
	{
		await validator.ValidateAndThrowAsync(model);

		return mapper.Map<ActorViewModel>(
			await actorService.Create(mapper.Map<ActorModel>(model)));
	}

	[HttpPut]
	public async Task<ActorViewModel> Update(ActorViewModel model)
	{
		await validator.ValidateAndThrowAsync(model);

		return mapper.Map<ActorViewModel>(
			await actorService.Update(mapper.Map<ActorModel>(model)));
	}

	[HttpDelete]
	public async Task<ActorViewModel> Delete(Guid id)
	{
		return mapper.Map<ActorViewModel>(await actorService.Delete(id));
	}
}
