using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;

public interface IBookingService : IGenericService<Booking>
{
    void TBookingStatusChange(int id,string status); 
    int TGetBookingCount();
    List<Booking> TLast6Bookings();
}
