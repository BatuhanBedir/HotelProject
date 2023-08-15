using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class SubscribeManager : ISubscribeService
{
    private readonly ISubscribeRepository _subscribeRepository;

    public SubscribeManager(ISubscribeRepository subscribeRepository)
    {
        _subscribeRepository = subscribeRepository;
    }
    public async Task AddAsync(Subscribe t)
    {
        await _subscribeRepository.AddAsync(t);
        await _subscribeRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Subscribe t)
    {
        await _subscribeRepository.DeleteAsync(t);
        await _subscribeRepository.SaveChangesAsync();

    }

    public async Task<List<Subscribe>> GetAllAsync()
    {
        return await _subscribeRepository.GetAllAsync();
    }

    public async Task<Subscribe> GetByIdAsync(int id)
    {
        return await _subscribeRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Subscribe t)
    {
        await _subscribeRepository.UpdateAsync(t);
        await _subscribeRepository.SaveChangesAsync();
    }

}
