using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;

public interface IStaffRepository : IGenericRepository<Staff>
{
    Task<List<Staff>> Last4StaffAsync();
}
