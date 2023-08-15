using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;

public interface IBookingRepository : IGenericRepository<Booking>
{
    Task BookingStatusChangeAsync(int id, string status);
    Task<List<Booking>> Last6BookingAsync();
}
