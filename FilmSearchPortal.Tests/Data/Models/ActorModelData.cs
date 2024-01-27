namespace FilmSearchPortal.Tests.Data.Models;

public static class ActorModelData
{
	public static ActorModel InitActorModel()
	{
		var actor = new ActorModel
		{
			Id = Guid.NewGuid(),
			FirstName = "John",
			LastName = "Doe"
		};

		return actor;
	}

	public static List<ActorModel> InitActorModelCollection()
	{
		return [InitActorModel()];
	}
}