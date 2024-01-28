namespace FilmSearchPortal.API.Validators;

public class FilmValidator : AbstractValidator<FilmViewModel>
{
	public FilmValidator()
	{
		RuleFor(film => film.Title)
			.NotNull()
			.Length(2, 100)
			.WithMessage("Title must be between {MinLength} and {MaxLength} characters.");

		RuleFor(film => film.Duration)
			.NotNull()
			.InclusiveBetween(TimeSpan.FromMinutes(1), TimeSpan.FromHours(4))
			.WithMessage("Film duration must be between {From} minute and {To} hours");

		RuleFor(film => film.ReleaseYear)
			.NotNull()
			.LessThanOrEqualTo(DateTime.Now.Year)
			.WithMessage("Release year cannot be in the future.");
	}
}
