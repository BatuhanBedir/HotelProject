using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfSubscribeRepository : GenericRepository<Subscribe>, ISubscribeRepository
{
    public EfSubscribeRepository(Context context) : base(context)
    {
    }
}
