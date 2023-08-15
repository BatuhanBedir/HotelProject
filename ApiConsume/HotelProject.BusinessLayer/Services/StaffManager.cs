using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class StaffManager : IStaffService
{
    private readonly IStaffRepository _staffRepository;

    public StaffManager(IStaffRepository staffRepository)
    {
        _staffRepository = staffRepository;
    }
    public async Task AddAsync(Staff t)
    {
        await _staffRepository.AddAsync(t);
        await _staffRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Staff t)
    {
        await _staffRepository.DeleteAsync(t);
        await _staffRepository.SaveChangesAsync();

    }

    public async Task<List<Staff>> GetAllAsync()
    {
        return await _staffRepository.GetAllAsync();
    }

    public async Task<Staff> GetByIdAsync(int id)
    {
        return await _staffRepository.GetByIdAsync(id);
    }

    public async Task<int> GetStaffCountAsync()
    {
        var staffs =await _staffRepository.GetAllAsync();
        return staffs.Count();
    }

    public async Task<List<Staff>> Last4StaffAsync()
    {
        return await _staffRepository.Last4StaffAsync();
    }

    public async Task UpdateAsync(Staff t)
    {
        await _staffRepository.UpdateAsync(t);
        await _staffRepository.SaveChangesAsync();
    }
}
