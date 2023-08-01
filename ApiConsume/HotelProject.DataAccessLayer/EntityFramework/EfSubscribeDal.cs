using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfSubscribeDal : GenericRepository<Subscribe>, ISubscribeDal
{
    public EfSubscribeDal(Context context) : base(context)
    {
    }
}
