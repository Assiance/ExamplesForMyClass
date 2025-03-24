using MovieTracker.Core;
using MovieTracker.Data.Interfaces;
using MovieTracker.Services.Interfaces;

namespace MovieTracker.Services.Services;

public class MovieService : IMovieService
{
    readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<List<Movie>> GetMoviesAsync()
    {
        return await _movieRepository.GetMoviesAsync();
    }
}