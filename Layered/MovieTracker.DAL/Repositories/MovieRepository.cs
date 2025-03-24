using MovieTracker.Core;
using MovieTracker.Data.Interfaces;

namespace MovieTracker.Data.Repositories;

public class MovieRepository : IMovieRepository
{
    public Task<List<Movie>> GetMoviesAsync()
    {
        throw new NotImplementedException();
    }
}
