using HotelProject.EntityLayer.Abstract;

namespace HotelProject.EntityLayer.Concrete;

public class Service : BaseEntity
{
    public string Icon { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
}
