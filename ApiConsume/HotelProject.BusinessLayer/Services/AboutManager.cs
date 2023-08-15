using HotelProject.BusinessLayer.Interfaces;
using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class AboutManager : IAboutService
{
    private readonly IAboutRepository _aboutRepository;

    public AboutManager(IAboutRepository aboutRepository)
    {
        _aboutRepository = aboutRepository;
    }

    public async Task AddAsync(About t)
    {
        await _aboutRepository.AddAsync(t);
        await _aboutRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(About t)
    {
        await _aboutRepository.DeleteAsync(t);
        await _aboutRepository.SaveChangesAsync();

    }

    public async Task<List<About>> GetAllAsync()
    {
       return await _aboutRepository.GetAllAsync();
    }

    public async Task<About> GetByIdAsync(int id)
    {
        return await _aboutRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(About t)
    {
        await _aboutRepository.UpdateAsync(t); 
        await _aboutRepository.SaveChangesAsync();
    }
}
