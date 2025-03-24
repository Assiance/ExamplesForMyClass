﻿namespace MovieTracker.Core;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int ReleaseDate { get; set; }
}