namespace FilmSearchPortal.Tests.Data.Entities;

public static class ActorEntityData
{
	public static Actor InitActorEntity()
	{
		var actor = new Actor
		{
			Id = Guid.NewGuid(),
			FirstName = "John",
			LastName = "Doe"
		};

		return actor;
	}

	public static List<Actor> InitActorEntityCollection()
	{
		return [InitActorEntity()];
	}
}