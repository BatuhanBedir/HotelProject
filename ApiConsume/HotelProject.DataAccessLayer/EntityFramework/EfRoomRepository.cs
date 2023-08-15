using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfRoomRepository : GenericRepository<Room>, IRoomRepository
{
    public EfRoomRepository(Context context) : base(context)
    {
    }
}
