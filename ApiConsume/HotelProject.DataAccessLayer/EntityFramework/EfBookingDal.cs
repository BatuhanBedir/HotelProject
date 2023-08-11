using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using System.Windows.Markup;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfBookingDal : GenericRepository<Booking>, IBookingDal
{
    public EfBookingDal(Context context) : base(context)
    {
    }
    public void BookingStatusChangeApproved(int id)
    {
        var context = new Context();
        var value = context.Bookings.FirstOrDefault(x=>x.Id==id);
        value.Status = "Onaylandı";
        context.SaveChanges();
    }

    public List<Booking> Last6Booking()
    {
        var context=new Context();
        return context.Bookings.OrderByDescending(x=>x.Id).Take(6).ToList();
    }
}
