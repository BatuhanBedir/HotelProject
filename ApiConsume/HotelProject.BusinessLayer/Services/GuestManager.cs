using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class GuestManager : IGuestService
{
    private readonly IGuestRepository _guestRepository;
    private readonly IAboutRepository _aboutRepository;


    public GuestManager(IGuestRepository guestRepository, IAboutRepository aboutRepository)
    {
        _guestRepository = guestRepository;
        _aboutRepository = aboutRepository;
    }
    public async Task DeleteAsync(Guest t)
    {
        await _guestRepository.DeleteAsync(t);
        var about = await _aboutRepository.GetAllAsync();
        foreach (var item in about)
        {
            item.StaffCount--;
            await _aboutRepository.UpdateAsync(item);
        }
        await _guestRepository.SaveChangesAsync();

    }
    public async Task<Guest> GetByIdAsync(int id)
    {
        return await _guestRepository.GetByIdAsync(id);
    }

    public async Task<List<Guest>> GetAllAsync()
    {
        return await _guestRepository.GetAllAsync();
    }
    public async Task AddAsync(Guest t)
    {
        await _guestRepository.AddAsync(t);
        var about = await _aboutRepository.GetAllAsync();
        foreach (var item in about)
        {
            item.StaffCount++;
            await _aboutRepository.UpdateAsync(item);
        }
        await _guestRepository.SaveChangesAsync();
    }
    public async Task UpdateAsync(Guest t)
    {
        await _guestRepository.UpdateAsync(t);
        await _guestRepository.SaveChangesAsync();
    }

}
