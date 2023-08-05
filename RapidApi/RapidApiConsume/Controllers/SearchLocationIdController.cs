using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers;

public class SearchLocationIdController : Controller
{
    public async Task<IActionResult> Index(string cityName)
    {
        string defaultCityName = "Paris"; // Default city name if cityName is null or empty
        string apiUrl = $"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={(!string.IsNullOrEmpty(cityName) ? cityName : defaultCityName)}&locale=en-gb";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "5f6daadaaamsh20826ac2e0e4fbfp1733ebjsn0769e442c566");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "booking-com.p.rapidapi.com");

            using (var response = await client.GetAsync(apiUrl))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var bookingApiLocationSearchVm = JsonConvert.DeserializeObject<List<BookingApiLocationSearchVm>>(body);

                return View(bookingApiLocationSearchVm.Take(1).ToList());
            }
        }

    }

}
