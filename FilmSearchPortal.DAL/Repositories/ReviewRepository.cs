namespace FilmSearchPortal.DAL.Repositories;

public class ReviewRepository(ApplicationDbContext context) : GenericRepository<Review>(context), IReviewRepository
{
	public override Task<Review?> Get(Guid id)
	{
		return Set
			.Include(review => review.Film)
			.FirstOrDefaultAsync(review => review.Id == id);
	}

	public override async Task<IEnumerable<Review>> GetAll()
	{
		return await Set
			.Include(review => review.Film)
			.ToListAsync();
	}
}