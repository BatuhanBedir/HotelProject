using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Abstract;

namespace HotelProject.DataAccessLayer.EntityFramework.Generic;

public class GenericRepository<T> : IGenericDal<T> where T : BaseEntity
{
    private readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
    }

    public void Delete(T t)
    {
        _context.Remove(t);
        _context.SaveChanges();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().FirstOrDefault(item => item.Id == id);
    }

    public List<T> GetList()
    {
        return _context.Set<T>().ToList();
    }

    public void Insert(T t)
    {
        _context.Add(t);
        _context.SaveChanges();
    }

    public void Update(T t)
    {
        _context.Update(t);
        _context.SaveChanges();
    }
}
