using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfWorkLocationDal : GenericRepository<WorkLocation>, IWorkLocationDal
{
    public EfWorkLocationDal(Context context) : base(context)
    {
    }
}
