namespace FilmSearchPortal.Tests.Tests;

public class ReviewServiceTest
{
	private GenericService<ReviewModel, Review> ReviewService { get; }

	private Mock<IReviewRepository> MockReviewRepository { get; } = new();

	public ReviewServiceTest()
	{
		var mockMapper = new Mock<IMapper>();

		mockMapper
			.Setup(mp => mp.Map<ReviewModel>(It.IsAny<Review>()))
			.Returns(ReviewModelData.InitReviewModel());

		mockMapper
			.Setup(mp => mp.Map<IEnumerable<ReviewModel>>(It.IsAny<IEnumerable<Review>>()))
			.Returns(ReviewModelData.InitReviewModelCollection());

		mockMapper
			.Setup(mp => mp.Map<Review>(It.IsAny<ReviewModel>()))
			.Returns(ReviewEntityData.InitReviewEntity());

		ReviewService = new GenericService<ReviewModel, Review>(MockReviewRepository.Object, mockMapper.Object);
	}

	[Fact]
	public async Task Create_InputReviewModel_ReturnExpectedModel()
	{
		var reviewModel = ReviewModelData.InitReviewModel();
		MockReviewRepository
			.Setup(rep => rep.Create(It.IsAny<Review>()))
			.ReturnsAsync(ReviewEntityData.InitReviewEntity());

		var result = await ReviewService.Create(reviewModel);

		MockReviewRepository
			.Verify(rep => rep.Create(It.IsAny<Review>()));
		result.Title
			.ShouldBeEquivalentTo(reviewModel.Title);
	}

	[Fact]
	public async Task Delete_InputReviewModel_ReturnExpectedModel()
	{
		MockReviewRepository
			.Setup(rep => rep.Delete(It.IsAny<Guid>()))
			.ReturnsAsync(ReviewEntityData.InitReviewEntity());

		var result = await ReviewService.Delete(Guid.NewGuid());

		MockReviewRepository
			.Verify(rep => rep.Delete(It.IsAny<Guid>()));
		result.Title
			.ShouldBeEquivalentTo(ReviewModelData.InitReviewModel().Title);
	}

	[Fact]
	public async Task Get_InputSomeString_ReturnExpectedModel()
	{
		MockReviewRepository
			.Setup(rep => rep.Get(It.IsAny<Guid>()))
			.ReturnsAsync(ReviewEntityData.InitReviewEntity());

		var result = await ReviewService.Get(Guid.NewGuid());

		MockReviewRepository
			.Verify(rep => rep.Get(It.IsAny<Guid>()));
		result.Title
			.ShouldBeEquivalentTo(ReviewModelData.InitReviewModel().Title);
	}

	[Fact]
	public async Task GetAll_CommonInvoking_NotEmptyList()
	{
		var reviewModel = ReviewModelData.InitReviewModel();
		MockReviewRepository
			.Setup(rep => rep.GetAll())
			.ReturnsAsync(ReviewEntityData.InitReviewEntityCollection());

		var result = await ReviewService.GetAll();

		MockReviewRepository
			.Verify(rep => rep.GetAll());
		result.FirstOrDefault(p => p.Title == reviewModel.Title)
			.ShouldNotBeNull();
	}

	[Fact]
	public async Task Update_InputReviewModel_ReturnExpectedModel()
	{
		var reviewModel = ReviewModelData.InitReviewModel();
		MockReviewRepository
			.Setup(rep => rep.Update(It.IsAny<Review>()))
			.ReturnsAsync(ReviewEntityData.InitReviewEntity());

		var result = await ReviewService.Update(reviewModel);

		MockReviewRepository
			.Verify(rep => rep.Update(It.IsAny<Review>()));
		result.Title
			.ShouldBeEquivalentTo(reviewModel.Title);
	}
}