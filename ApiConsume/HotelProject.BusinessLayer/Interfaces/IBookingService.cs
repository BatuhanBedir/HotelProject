using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;

public interface IBookingService : IGenericService<Booking>
{
    Task BookingStatusChangeAsync(int id,string status); 
    Task<int> GetBookingCountAsync();
    Task<List<Booking>> Last6BookingsAsync();
}
