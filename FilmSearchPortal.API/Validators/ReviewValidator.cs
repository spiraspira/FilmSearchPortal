namespace FilmSearchPortal.API.Validators;

public class ReviewValidator : AbstractValidator<ReviewModel>
{
	public ReviewValidator()
	{
		RuleFor(review => review.Title)
			.NotNull()
			.Length(2, 100)
			.WithMessage("Title must be between {MinLength} and {MaxLength} characters.");

		RuleFor(review => review.Description)
			.NotNull()
			.Length(2, 500)
			.WithMessage("Description must be between {MinLength} and {MaxLength} characters.");

		RuleFor(actor => actor.Rate)
			.NotNull()
			.InclusiveBetween(1, 10)
			.WithMessage("Rate must be between {From} and {To}.");
	}
}
