using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfServiceDal : GenericRepository<Service>,IServiceDal
{
    public EfServiceDal(Context context) : base(context)
    {
    }
}
