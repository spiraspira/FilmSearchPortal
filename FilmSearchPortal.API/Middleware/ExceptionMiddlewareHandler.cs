namespace FilmSearchPortal.API.Middleware;

public class ExceptionHandlerMiddleware(RequestDelegate next)
{
	public async Task InvokeAsync(HttpContext context, ILogger<ExceptionHandlerMiddleware> logger)
	{
		try
		{
			await next.Invoke(context);
		}
		catch (Exception ex)
		{
			const int statusCode = (int)HttpStatusCode.InternalServerError;

			var result = JsonConvert.SerializeObject(new
			{
				StatusCode = statusCode,
				ErrorMessage = ex.Message
			});

			context.Response.ContentType = "application/json";

			context.Response.StatusCode = statusCode;

			logger.LogError(ex.Message);

			await context.Response.WriteAsync(result);

		}
	}
}