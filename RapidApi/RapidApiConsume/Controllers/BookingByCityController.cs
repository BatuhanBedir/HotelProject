using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers;

public class BookingByCityController : Controller
{
    public async Task<IActionResult> Index(string cityId)
    {
        string apiUrl = $"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-08-24&filter_by_currency=EUR&dest_id={(!string.IsNullOrWhiteSpace(cityId) ? cityId : "-1456928")}&locale=en-gb&checkout_date=2023-08-27&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1";

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "5f6daadaaamsh20826ac2e0e4fbfp1733ebjsn0769e442c566");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "booking-com.p.rapidapi.com");

            using (var response = await client.GetAsync(apiUrl))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<BookingApiVm>(body);

                return View(value.results.ToList());
            }
        }

    }

}