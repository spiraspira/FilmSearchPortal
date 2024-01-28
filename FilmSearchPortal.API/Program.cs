var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IValidator<ActorViewModel>, ActorValidator>();
builder.Services.AddScoped<IValidator<FilmViewModel>, FilmValidator>();
builder.Services.AddScoped<IValidator<ReviewViewModel>, ReviewValidator>();
builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(FilmSearchPortal.BLL.Mapper.MappingProfile));
builder.Services.AddControllers();
builder.Services.AddBusinessLogic(builder.Configuration);
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.MapControllers();

app.Run();