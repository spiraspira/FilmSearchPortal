namespace FilmSearchPortal.API.Mapper;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<ActorModel, ActorViewModel>().ReverseMap();

		CreateMap<FilmModel, FilmViewModel>().ReverseMap();

		CreateMap<FilmActorModel, FilmActorViewModel>().ReverseMap();

		CreateMap<ReviewModel, ReviewViewModel>().ReverseMap();
	}
}