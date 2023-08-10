using HotelProject.EntityLayer.Abstract;

namespace HotelProject.EntityLayer.Concrete;

public class Category : BaseEntity
{
    public Category()
    {
        Contacts = new HashSet<Contact>();
    }
    public string Name { get; set; }
    public ICollection <Contact> Contacts { get; set; }
}
