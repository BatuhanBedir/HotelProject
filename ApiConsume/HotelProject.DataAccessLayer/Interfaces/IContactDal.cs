using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;

public interface IContactDal : IGenericDal<Contact>
{
    public int GetContactCount();
}
