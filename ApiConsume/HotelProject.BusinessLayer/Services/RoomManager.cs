using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class RoomManager : IRoomService
{
    private readonly IRoomRepository _roomRepository;
    private readonly IAboutRepository _aboutRepository;

    public RoomManager(IRoomRepository roomRepository, IAboutRepository aboutRepository)
    {
        _roomRepository = roomRepository;
        _aboutRepository = aboutRepository;
    }
    public async Task<List<Room>> GetAllAsync()
    {
        return await _roomRepository.GetAllAsync();
    }

    public async Task<Room> GetByIdAsync(int id)
    {
        return await _roomRepository.GetByIdAsync(id);
    }
    public async Task DeleteAsync(Room t)
    {
        await _roomRepository.DeleteAsync(t);
        var a = await _aboutRepository.GetAllAsync();
        foreach (var item in a)
        {
            item.RoomCount--;
            await _aboutRepository.UpdateAsync(item);
        }
        await _roomRepository.SaveChangesAsync();
    }
    public async Task AddAsync(Room t)
    {
        await _roomRepository.AddAsync(t);
        List<About>? a =await _aboutRepository.GetAllAsync();
        foreach (var item in a)
        {
            item.RoomCount++;
            await _aboutRepository.UpdateAsync(item);
        }
        await _roomRepository.SaveChangesAsync();
    }
    public async Task<int> RoomCountAsync()
    {
        var rooms = await _roomRepository.GetAllAsync();
        return rooms.Count();
    }

    public async Task UpdateAsync(Room t)
    {
        await _roomRepository.UpdateAsync(t);
        await _roomRepository.SaveChangesAsync();
    }
}
