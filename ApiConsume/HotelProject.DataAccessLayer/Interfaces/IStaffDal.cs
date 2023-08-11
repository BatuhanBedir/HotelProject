using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;

public interface IStaffDal : IGenericDal<Staff>
{
    List<Staff> Last4Staff();
}
