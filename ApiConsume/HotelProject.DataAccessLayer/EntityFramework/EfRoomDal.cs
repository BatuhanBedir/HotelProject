using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfRoomDal : GenericRepository<Room>, IRoomDal
{
    public EfRoomDal(Context context) : base(context)
    {
    }
}
