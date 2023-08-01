using HotelProject.EntityLayer.Abstract;

namespace HotelProject.EntityLayer.Concrete;

public class Room : BaseEntity
{
    public string CoverImage { get; set; }
    public string Number { get; set; }
    public int Price { get; set; }
    public string Title { get; set; }
    public string BedCount { get; set; }
    public string BathCount { get; set; }
    public string Description { get; set; }
}
