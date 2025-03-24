using Microsoft.AspNetCore.Mvc;
using MovieTracker.Services.Interfaces;

namespace MovieTracker.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : Controller
{
    readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetMovies()
    {
        return Ok();
    }
}