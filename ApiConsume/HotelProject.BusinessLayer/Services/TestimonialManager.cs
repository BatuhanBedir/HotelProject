using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class TestimonialManager : ITestimonialService
{
    private readonly ITestimonialRepository _testimonialRepository;

    public TestimonialManager(ITestimonialRepository testimonialRepository)
    {
        _testimonialRepository = testimonialRepository;
    }
    public async Task AddAsync(Testimonial t)
    {
        await _testimonialRepository.AddAsync(t);
        await _testimonialRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Testimonial t)
    {
        await _testimonialRepository.DeleteAsync(t);
        await _testimonialRepository.SaveChangesAsync();

    }

    public async Task<List<Testimonial>> GetAllAsync()
    {
        return await _testimonialRepository.GetAllAsync();
    }

    public async Task<Testimonial> GetByIdAsync(int id)
    {
        return await _testimonialRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Testimonial t)
    {
        await _testimonialRepository.UpdateAsync(t);
        await _testimonialRepository.SaveChangesAsync();
    }

}
