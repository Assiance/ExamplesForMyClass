using MovieTracker.Core;

namespace MovieTracker.Services.Interfaces;

public interface IMovieService
{
    public Task<List<Movie>> GetMoviesAsync();
}