using HotelProject.EntityLayer.Abstract;

namespace HotelProject.EntityLayer.Concrete;

public class Contact : BaseEntity
{
    public string Name { get; set; }
    public string Mail { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public DateTime Date { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
