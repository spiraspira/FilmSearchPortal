namespace FilmSearchPortal.Tests.Tests;

public class ActorServiceTest
{
	private ActorService ActorService { get; }

	private Mock<IActorRepository> MockActorRepository { get; } = new();

	public ActorServiceTest()
	{
		var mockMapper = new Mock<IMapper>();

		mockMapper
			.Setup(mp => mp.Map<ActorModel>(It.IsAny<Actor>()))
			.Returns(ActorModelData.InitActorModel());

		mockMapper
			.Setup(mp => mp.Map<IEnumerable<ActorModel>>(It.IsAny<IEnumerable<Actor>>()))
			.Returns(ActorModelData.InitActorModelCollection());

		mockMapper
			.Setup(mp => mp.Map<Actor>(It.IsAny<ActorModel>()))
			.Returns(ActorEntityData.InitActorEntity());

		ActorService = new ActorService(MockActorRepository.Object, mockMapper.Object);
	}

	[Fact]
	public async Task Create_InputActorModel_ReturnExpectedModel()
	{
		var actorModel = ActorModelData.InitActorModel();
		MockActorRepository
			.Setup(rep => rep.Create(It.IsAny<Actor>()))
			.ReturnsAsync(ActorEntityData.InitActorEntity());

		var result = await ActorService.Create(actorModel);

		MockActorRepository
			.Verify(rep => rep.Create(It.IsAny<Actor>()));
		result.FirstName
			.ShouldBeEquivalentTo(actorModel.FirstName);
	}

	[Fact]
	public async Task Delete_InputActorModel_ReturnExpectedModel()
	{
		MockActorRepository
			.Setup(rep => rep.Delete(It.IsAny<Guid>()))
			.ReturnsAsync(ActorEntityData.InitActorEntity());

		var result = await ActorService.Delete(Guid.NewGuid());

		MockActorRepository
			.Verify(rep => rep.Delete(It.IsAny<Guid>()));
		result.FirstName
			.ShouldBeEquivalentTo(ActorModelData.InitActorModel().FirstName);
	}

	[Fact]
	public async Task Get_InputSomeString_ReturnExpectedModel()
	{
		MockActorRepository
			.Setup(rep => rep.Get(It.IsAny<Guid>()))
			.ReturnsAsync(ActorEntityData.InitActorEntity());

		var result = await ActorService.Get(Guid.NewGuid());

		MockActorRepository
			.Verify(rep => rep.Get(It.IsAny<Guid>()));
		result.FirstName
			.ShouldBeEquivalentTo(ActorModelData.InitActorModel().FirstName);
	}

	[Fact]
	public async Task GetAll_CommonInvoking_NotEmptyList()
	{
		var actorModel = ActorModelData.InitActorModel();
		MockActorRepository
			.Setup(rep => rep.GetAll())
			.ReturnsAsync(ActorEntityData.InitActorEntityCollection());

		var result = await ActorService.GetAll();

		MockActorRepository
			.Verify(rep => rep.GetAll());
		result.FirstOrDefault(p => p.FirstName == actorModel.FirstName)
			.ShouldNotBeNull();
	}

	[Fact]
	public async Task Update_InputActorModel_ReturnExpectedModel()
	{
		var actorModel = ActorModelData.InitActorModel();
		MockActorRepository
			.Setup(rep => rep.Update(It.IsAny<Actor>()))
			.ReturnsAsync(ActorEntityData.InitActorEntity());

		var result = await ActorService.Update(actorModel);

		MockActorRepository
			.Verify(rep => rep.Update(It.IsAny<Actor>()));
		result.FirstName
			.ShouldBeEquivalentTo(actorModel.FirstName);
	}
}