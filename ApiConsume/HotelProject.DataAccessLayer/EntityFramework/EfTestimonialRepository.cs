using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfTestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
{
    public EfTestimonialRepository(Context context) : base(context)
    {
    }
}
