using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class SendMessageManager : ISendMessageService
{
    private readonly ISendMessageRepository _sendMessageRepository;

    public SendMessageManager(ISendMessageRepository sendMessageRepository)
    {
        _sendMessageRepository = sendMessageRepository;
    }

    public async Task AddAsync(SendMessage t)
    {
        await _sendMessageRepository.AddAsync(t);
        await _sendMessageRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(SendMessage t)
    {
        await _sendMessageRepository.DeleteAsync(t);
        await _sendMessageRepository.SaveChangesAsync();

    }

    public async Task<List<SendMessage>> GetAllAsync()
    {
        return await _sendMessageRepository.GetAllAsync();
    }

    public async Task<SendMessage> GetByIdAsync(int id)
    {
        return await _sendMessageRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(SendMessage t)
    {
        await _sendMessageRepository.UpdateAsync(t);
        await _sendMessageRepository.SaveChangesAsync();
    }

    public async Task<int> GetSendMessageCountAsync()
    {
        var sendMessages = await _sendMessageRepository.GetAllAsync();
        return sendMessages.Count();
    }
}
