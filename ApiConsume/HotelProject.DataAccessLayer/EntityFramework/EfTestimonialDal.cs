using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
{
    public EfTestimonialDal(Context context) : base(context)
    {
    }
}
