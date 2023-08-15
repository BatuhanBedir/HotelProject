using HotelProject.EntityLayer.Abstract;

namespace HotelProject.DataAccessLayer.Interfaces.Generic;

public interface IGenericRepository<T> : IUnitOfWork where T : class
{
    Task AddAsync(T t);
    Task DeleteAsync(T t);
    Task UpdateAsync(T t);
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
}
