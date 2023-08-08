namespace HotelProject.WebUI.Dtos.SendMessage;

public class ResultSendBoxDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
    public string ReceiverName { get; set; }
    public string ReceiverMail { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Date { get; set; }
}
