﻿namespace FilmSearchPortal.BLL.Models;

public class ReviewModel : Model
{
	public string? Title { get; set; }

	public string? Description { get; set; }

	public int? Rate { get; set; }

	public Guid? FilmId { get; set; }

	public FilmModel? Film { get; set; }
}