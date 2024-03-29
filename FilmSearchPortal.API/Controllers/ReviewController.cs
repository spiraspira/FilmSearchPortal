﻿namespace FilmSearchPortal.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReviewController(
	IMapper mapper,
	IGenericService<ReviewModel> reviewService,
	IValidator<ReviewViewModel> validator)
	: ControllerBase
{
	[HttpGet("{id}")]
	public async Task<ReviewViewModel> Get(Guid id)
	{
		return mapper.Map<ReviewViewModel>(await reviewService.Get(id));
	}

	[HttpGet]
	public async Task<IEnumerable<ReviewViewModel>> GetAll()
	{
		return mapper.Map<IEnumerable<ReviewViewModel>>(await reviewService.GetAll());
	}

	[HttpPost]
	public async Task<ReviewViewModel> Create(ReviewViewModel model)
	{
		await validator.ValidateAndThrowAsync(model);

		return mapper.Map<ReviewViewModel>(
			await reviewService.Create(mapper.Map<ReviewModel>(model)));
	}

	[HttpPut]
	public async Task<ReviewViewModel> Update(ReviewViewModel model)
	{
		await validator.ValidateAndThrowAsync(model);

		return mapper.Map<ReviewViewModel>(
			await reviewService.Update(mapper.Map<ReviewModel>(model)));
	}

	[HttpDelete]
	public async Task<ReviewViewModel> Delete(Guid id)
	{
		return mapper.Map<ReviewViewModel>(await reviewService.Delete(id));
	}
}