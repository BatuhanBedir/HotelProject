using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.DataAccessLayer.Migrations;
using HotelProject.EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework.Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly Context _context;
    protected readonly DbSet<T> _table;
    public GenericRepository(Context context)
    {
        _context = context;
        _table =_context.Set<T>();
    }

    public async Task AddAsync(T t)
    {
        await _table.AddAsync(t);
    }

    public Task DeleteAsync(T t)
    {
        return Task.FromResult(_table.Remove(t));
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _table.ToListAsync();
    }
    public Task<T> GetByIdAsync(int id)
    {
        return _table.FirstOrDefaultAsync(x=>x.Id == id);
    }

    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T t)
    {
        await Task.FromResult(_table.Update(t));
    }
}
