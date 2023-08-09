using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers;

public class AdminMailController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(AdminMailVm model)
    {
        MimeMessage mimeMessage = new MimeMessage();

        //kimden
        MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "batuhan.bedir133@gmail.com");
        mimeMessage.From.Add(mailboxAddressFrom);

        //kime
        MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
        mimeMessage.To.Add(mailboxAddressTo);

        //mesaj içeriği
        var bodyBuilder = new BodyBuilder();
        bodyBuilder.TextBody = model.Body;
        mimeMessage.Body = bodyBuilder.ToMessageBody();
        mimeMessage.Subject = model.Subject;

        SmtpClient client = new SmtpClient();
        client.Connect("smtp.gmail.com", 587,false);
        client.Authenticate("batuhan.bedir133@gmail.com", "tybhixzbrcwuydqq");
        client.Send(mimeMessage);
        client.Disconnect(true);

        return View();
    }
}
