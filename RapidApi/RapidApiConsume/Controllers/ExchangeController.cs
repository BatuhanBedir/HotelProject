using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers;

public class ExchangeController : Controller
{
    public async Task<IActionResult> Index()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
            Headers =
    {
        { "X-RapidAPI-Key", "5f6daadaaamsh20826ac2e0e4fbfp1733ebjsn0769e442c566" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ExchangeVm>(body);

            return View(values.exchange_rates.ToList());
        }

    }
}
