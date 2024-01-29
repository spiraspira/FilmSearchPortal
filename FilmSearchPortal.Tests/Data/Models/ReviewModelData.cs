namespace FilmSearchPortal.Tests.Data.Models;

public static class ReviewModelData
{
	public static ReviewModel InitReviewModel()
	{
		var review = new ReviewModel
		{
			Id = Guid.NewGuid(),
			Title = "Test"
		};

		return review;
	}

	public static List<ReviewModel> InitReviewModelCollection()
	{
		return [InitReviewModel()];
	}
}