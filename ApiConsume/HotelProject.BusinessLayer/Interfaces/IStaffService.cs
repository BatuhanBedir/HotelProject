using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;

public interface IStaffService : IGenericService<Staff>
{
    int TGetStaffCount();
    List<Staff> TLast4Staff();

}
