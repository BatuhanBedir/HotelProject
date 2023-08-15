using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Windows.Markup;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfBookingRepository : GenericRepository<Booking>, IBookingRepository
{
    public EfBookingRepository(Context context) : base(context)
    {
    }

    public async Task BookingStatusChangeAsync(int id, string status)
    {
        var value = await _table.FirstOrDefaultAsync(t => t.Id == id);
        value.Status = status;
    }

    public async Task<List<Booking>> Last6BookingAsync()
    {
        return await _table.OrderByDescending(x => x.Id).Take(6).ToListAsync();
    }
}
