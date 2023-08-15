using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfWorkLocationRepository : GenericRepository<WorkLocation>, IWorkLocationRepository
{
    public EfWorkLocationRepository(Context context) : base(context)
    {
    }
}
