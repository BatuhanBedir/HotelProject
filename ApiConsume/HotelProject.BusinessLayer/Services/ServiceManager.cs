using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class ServiceManager : IServiceService
{
    private readonly IServiceRepository _serviceRepository;

    public ServiceManager(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }
    public async Task AddAsync(Service t)
    {
        await _serviceRepository.AddAsync(t);
        await _serviceRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Service t)
    {
        await _serviceRepository.DeleteAsync(t);
        await _serviceRepository.SaveChangesAsync();

    }

    public async Task<List<Service>> GetAllAsync()
    {
        return await _serviceRepository.GetAllAsync();
    }

    public async Task<Service> GetByIdAsync(int id)
    {
        return await _serviceRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Service t)
    {
        await _serviceRepository.UpdateAsync(t);
        await _serviceRepository.SaveChangesAsync();
    }
}
