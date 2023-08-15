using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;
public class WorkLocationManager : IWorkLocationService
{
    private readonly IWorkLocationRepository _workLocationRepository;

    public WorkLocationManager(IWorkLocationRepository workLocationRepository)
    {
        _workLocationRepository = workLocationRepository;
    }

    public async Task AddAsync(WorkLocation t)
    {
        await _workLocationRepository.AddAsync(t);
        await _workLocationRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(WorkLocation t)
    {
        await _workLocationRepository.DeleteAsync(t);
        await _workLocationRepository.SaveChangesAsync();

    }

    public async Task<List<WorkLocation>> GetAllAsync()
    {
        return await _workLocationRepository.GetAllAsync();
    }

    public async Task<WorkLocation> GetByIdAsync(int id)
    {
        return await _workLocationRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(WorkLocation t)
    {
        await _workLocationRepository.UpdateAsync(t);
        await _workLocationRepository.SaveChangesAsync();
    }

}
