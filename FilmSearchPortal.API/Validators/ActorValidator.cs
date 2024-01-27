namespace FilmSearchPortal.API.Validators;

public class ActorValidator : AbstractValidator<ActorViewModel>
{
	public ActorValidator()
	{
		RuleFor(actor => actor.FirstName)
			.NotNull()
			.Length(2, 50)
			.WithMessage("First name must be between {MinLength} and {MaxLength} characters.");

		RuleFor(actor => actor.LastName)
			.NotNull()
			.Length(2, 50)
			.WithMessage("Last name must be between {MinLength} and {MaxLength} characters.");

		RuleFor(actor => actor.DateOfBirth)
			.NotNull()
			.LessThanOrEqualTo(DateTime.Now)
			.WithMessage("Date of birth cannot be in the future.");
	}
}
