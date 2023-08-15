using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfStaffRepository : GenericRepository<Staff>, IStaffRepository
{
    public EfStaffRepository(Context context) : base(context)
    {
    }

    public async Task<List<Staff>> Last4StaffAsync()
    {
        return await _table.OrderByDescending(x => x.Id).Take(4).ToListAsync();
    }
}
