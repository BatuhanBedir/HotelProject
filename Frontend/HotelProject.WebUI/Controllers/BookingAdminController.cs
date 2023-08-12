using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers;

public class BookingAdminController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BookingAdminController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:1322/api/Booking");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
            return View(values);
        }
        return View();
    }
    public async Task<IActionResult> UpdateReservationStatus(int id, string status)
    {
        var client = _httpClientFactory.CreateClient();
        var content = new StringContent($"\"{status}\"", Encoding.UTF8, "application/json");

        var responseMessage = await client.PutAsync($"http://localhost:1322/api/Booking/BookingStatus?id={id}&status={status}", content);

        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> ApprovedReservation(int id)
    {
        return await UpdateReservationStatus(id, "Onayla");
    }

    public async Task<IActionResult> CancelReservation(int id)
    {
        return await UpdateReservationStatus(id, "İptal Edildi");
    }

    public async Task<IActionResult> WaitReservation(int id)
    {
        return await UpdateReservationStatus(id, "Bekletildi");
    }
    [HttpGet]
    public async Task<IActionResult> UpdateBooking(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"http://localhost:1322/api/Booking/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateBookingDto>(jsonData);
            return View(values);
        }
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
    {

        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(updateBookingDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("http://localhost:1322/api/Booking/UpdateBooking/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
}
