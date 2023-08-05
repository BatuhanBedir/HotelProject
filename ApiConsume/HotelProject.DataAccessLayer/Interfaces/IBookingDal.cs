using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;

public interface IBookingDal : IGenericDal<Booking>
{
    void BookingStatusChangeApproved(int id);
}
