namespace FilmSearchPortal.BLL.Mapper;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<Actor, ActorModel>().ReverseMap();

		CreateMap<Film, FilmModel>().ReverseMap();

		CreateMap<FilmActor, FilmActorModel>().ReverseMap();

		CreateMap<Review, ReviewModel>().ReverseMap();
	}
}