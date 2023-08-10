using HotelProject.WebUI.Dtos.ContactDto;
using HotelProject.WebUI.Dtos.SendMessage;
using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers;

public class AdminContactController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public AdminContactController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Inbox()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:1322/api/Contact");
        var responseMessageCount = await client.GetAsync("http://localhost:1322/api/Contact/GetContactCount");
        var responseSendMessageCount = await client.GetAsync("http://localhost:1322/api/SendMessage/GetSendMessageCount");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            ViewBag.contactCount = await responseMessageCount.Content.ReadAsStringAsync();
            ViewBag.sendMessageCount = await responseSendMessageCount.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<InboxContactDto>>(jsonData);
            return View(values);
        }

        return View();
    }
    public async Task<IActionResult> SendBox()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("http://localhost:1322/api/SendMessage");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultSendBoxDto>>(jsonData);
            return View(values);
        }

        return View();
    }

    [HttpGet]
    public IActionResult AddSendMessage()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> AddSendMessage(CreateSendMessageDto createSendMessageDto)
    {
        createSendMessageDto.Mail = "admin@gmail.com";
        createSendMessageDto.Name = "admin";
        createSendMessageDto.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createSendMessageDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("http://localhost:1322/api/SendMessage", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("SendBox");
        }
        return View();
    }
    public PartialViewResult SideBarAdminContactPartial()
    {
        return PartialView();
    }
    public PartialViewResult SideBarAdminContactCategoryPartial()
    {
        return PartialView();
    }
    public async Task<IActionResult> MessageDetailsBySendbox(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"http://localhost:1322/api/SendMessage/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<GetMessageByIdDto>(jsonData);
            return View(value);
        }
        return View();
    }
    public async Task<IActionResult> MessageDetailsByInbox(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"http://localhost:1322/api/Contact/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<InboxContactDto>(jsonData);
            return View(value);
        }
        return View();
    }
}
