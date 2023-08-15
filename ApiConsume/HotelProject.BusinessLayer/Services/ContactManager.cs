using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class ContactManager : IContactService
{
    private readonly IContactRepository _contactRepository;

    public ContactManager(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }
    public async Task AddAsync(Contact t)
    {
        await _contactRepository.AddAsync(t);
        await _contactRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Contact t)
    {
        await _contactRepository.DeleteAsync(t);
        await _contactRepository.SaveChangesAsync();
    }

    public async Task<List<Contact>> GetAllAsync()
    {
        return await _contactRepository.GetAllAsync();
    }

    public async Task<Contact> GetByIdAsync(int id)
    {
        return await _contactRepository.GetByIdAsync(id);
    }

    public async Task<int> GetContactCountAsync()
    {
        var contacts =await _contactRepository.GetAllAsync();
        return contacts.Count();
    }


    public async Task UpdateAsync(Contact t)
    {
        await _contactRepository.UpdateAsync(t);
        await _contactRepository.SaveChangesAsync();
    }

}
