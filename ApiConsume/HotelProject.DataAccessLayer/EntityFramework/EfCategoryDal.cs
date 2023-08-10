using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(Context context) : base(context)
    {
    }
}
