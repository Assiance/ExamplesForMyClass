using MovieTracker.Core;

namespace MovieTracker.Data.Interfaces;

public interface IMovieRepository
{
    Task<List<Movie>> GetMoviesAsync();
}