namespace FilmSearchPortal.Tests.Tests;

public class FilmServiceTest
{
	private FilmService FilmService { get; }

	private Mock<IFilmRepository> MockFilmRepository { get; } = new();

	public FilmServiceTest()
	{
		var mockMapper = new Mock<IMapper>();

		mockMapper
			.Setup(mp => mp.Map<FilmModel>(It.IsAny<Film>()))
			.Returns(FilmModelData.InitFilmModel());

		mockMapper
			.Setup(mp => mp.Map<IEnumerable<FilmModel>>(It.IsAny<IEnumerable<Film>>()))
			.Returns(FilmModelData.InitFilmModelCollection());

		mockMapper
			.Setup(mp => mp.Map<Film>(It.IsAny<FilmModel>()))
			.Returns(FilmEntityData.InitFilmEntity());

		FilmService = new FilmService(MockFilmRepository.Object, mockMapper.Object);
	}

	[Fact]
	public async Task Create_InputFilmModel_ReturnExpectedModel()
	{
		var filmModel = FilmModelData.InitFilmModel();
		MockFilmRepository
			.Setup(rep => rep.Create(It.IsAny<Film>()))
			.ReturnsAsync(FilmEntityData.InitFilmEntity());

		var result = await FilmService.Create(filmModel);

		MockFilmRepository
			.Verify(rep => rep.Create(It.IsAny<Film>()));
		result.Title
			.ShouldBeEquivalentTo(filmModel.Title);
	}

	[Fact]
	public async Task Delete_InputFilmModel_ReturnExpectedModel()
	{
		MockFilmRepository
			.Setup(rep => rep.Delete(It.IsAny<Guid>()))
			.ReturnsAsync(FilmEntityData.InitFilmEntity());

		var result = await FilmService.Delete(Guid.NewGuid());

		MockFilmRepository
			.Verify(rep => rep.Delete(It.IsAny<Guid>()));
		result.Title
			.ShouldBeEquivalentTo(FilmModelData.InitFilmModel().Title);
	}

	[Fact]
	public async Task Get_InputSomeString_ReturnExpectedModel()
	{
		MockFilmRepository
			.Setup(rep => rep.Get(It.IsAny<Guid>()))
			.ReturnsAsync(FilmEntityData.InitFilmEntity());

		var result = await FilmService.Get(Guid.NewGuid());

		MockFilmRepository
			.Verify(rep => rep.Get(It.IsAny<Guid>()));
		result.Title
			.ShouldBeEquivalentTo(FilmModelData.InitFilmModel().Title);
	}

	[Fact]
	public async Task GetAll_CommonInvoking_NotEmptyList()
	{
		var filmModel = FilmModelData.InitFilmModel();
		MockFilmRepository
			.Setup(rep => rep.GetAll())
			.ReturnsAsync(FilmEntityData.InitFilmEntityCollection());

		var result = await FilmService.GetAll();

		MockFilmRepository
			.Verify(rep => rep.GetAll());
		result.FirstOrDefault(p => p.Title == filmModel.Title)
			.ShouldNotBeNull();
	}

	[Fact]
	public async Task Update_InputFilmModel_ReturnExpectedModel()
	{
		var filmModel = FilmModelData.InitFilmModel();
		MockFilmRepository
			.Setup(rep => rep.Update(It.IsAny<Film>()))
			.ReturnsAsync(FilmEntityData.InitFilmEntity());

		var result = await FilmService.Update(filmModel);

		MockFilmRepository
			.Verify(rep => rep.Update(It.IsAny<Film>()));
		result.Title
			.ShouldBeEquivalentTo(filmModel.Title);
	}
}