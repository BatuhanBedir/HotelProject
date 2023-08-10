using HotelProject.EntityLayer.Abstract;

namespace HotelProject.EntityLayer.Concrete;

public class WorkLocation : BaseEntity
{
    public WorkLocation()
    {
        AppUsers = new HashSet<AppUser>();
    }
    public string Name { get; set; }
    public string City { get; set; }
    public ICollection<AppUser> AppUsers { get; set; }
}
