using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public EfCategoryRepository(Context context) : base(context)
    {
    }
}
