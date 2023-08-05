using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;
using System.Net.Http.Headers;
namespace RapidApiConsume.Controllers;

public class ImdbController : Controller
{
    public async Task<IActionResult> Index()
    {
        List<ApiMovieVm> apiMovieVms = new List<ApiMovieVm>();

        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
            Headers =
    {
        { "X-RapidAPI-Key", "5f6daadaaamsh20826ac2e0e4fbfp1733ebjsn0769e442c566" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            apiMovieVms = JsonConvert.DeserializeObject<List<ApiMovieVm>>(body);
            return View(apiMovieVms);
        }
    }
}
