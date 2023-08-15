using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;

public interface IStaffService : IGenericService<Staff>
{
    Task<int> GetStaffCountAsync();
    Task<List<Staff>> Last4StaffAsync();

}
