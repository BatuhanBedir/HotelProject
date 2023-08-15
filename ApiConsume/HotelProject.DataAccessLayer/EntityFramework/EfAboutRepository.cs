using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfAboutRepository : GenericRepository<About>, IAboutRepository
{
    public EfAboutRepository(Context context) : base(context)
    {
    }
}
