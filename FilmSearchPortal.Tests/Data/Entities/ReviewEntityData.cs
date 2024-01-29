namespace FilmSearchPortal.Tests.Data.Entities;

public static class ReviewEntityData
{
	public static Review InitReviewEntity()
	{
		var review = new Review
		{
			Id = Guid.NewGuid(),
			Title = "Test"
		};

		return review;
	}

	public static List<Review> InitReviewEntityCollection()
	{
		return [InitReviewEntity()];
	}
}