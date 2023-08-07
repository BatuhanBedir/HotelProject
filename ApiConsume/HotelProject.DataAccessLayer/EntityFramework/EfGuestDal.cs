using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfGuestDal : GenericRepository<Guest>, IGuestDal
{
    public EfGuestDal(Context context) : base(context)
    {
    }
}
