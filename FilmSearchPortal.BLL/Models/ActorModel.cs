﻿namespace FilmSearchPortal.BLL.Models;

public class ActorModel : Model
{
	public string? FirstName { get; set; }

	public string? LastName { get; set; }

	public DateTime DateOfBirth { get; set; }

	public string? Biography { get; set; }

	public List<FilmActorModel> FilmActors { get; set; } = [];
}