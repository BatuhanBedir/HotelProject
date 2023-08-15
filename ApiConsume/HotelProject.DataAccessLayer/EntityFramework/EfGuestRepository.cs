using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfGuestRepository : GenericRepository<Guest>, IGuestRepository
{
    public EfGuestRepository(Context context) : base(context)
    {
    }
}
