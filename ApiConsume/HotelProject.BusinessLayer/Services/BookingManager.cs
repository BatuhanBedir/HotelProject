using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class BookingManager : IBookingService
{
    private readonly IBookingRepository _bookingRepository;

    public BookingManager(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public async Task AddAsync(Booking t)
    {
        await _bookingRepository.AddAsync(t);
        await _bookingRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Booking t)
    {
        await _bookingRepository.DeleteAsync(t);
        await _bookingRepository.SaveChangesAsync();
    }

    public async Task<List<Booking>> GetAllAsync()
    {
        return await _bookingRepository.GetAllAsync();
    }

    public async Task<int> GetBookingCountAsync()
    {
        var bookings = await _bookingRepository.GetAllAsync();
        return bookings.Count();
    }

    public async Task<Booking> GetByIdAsync(int id)
    {
        return await _bookingRepository.GetByIdAsync(id);
    }

    public async Task<List<Booking>> Last6BookingsAsync()
    {
        return await _bookingRepository.Last6BookingAsync();
    }

    public async Task BookingStatusChangeAsync(int id, string status)
    {
        await _bookingRepository.BookingStatusChangeAsync(id, status);
        await _bookingRepository.SaveChangesAsync();
    }

    public async Task UpdateAsync(Booking t)
    {
        await _bookingRepository.UpdateAsync(t);
        await _bookingRepository.SaveChangesAsync();
    }

}
