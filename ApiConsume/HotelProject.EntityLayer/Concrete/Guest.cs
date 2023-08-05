using HotelProject.EntityLayer.Abstract;

namespace HotelProject.EntityLayer.Concrete;

public class Guest : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string City { get; set; }
}
