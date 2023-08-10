using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;

public interface IContactService : IGenericService<Contact>
{
    public int TGetContactCount();
}
