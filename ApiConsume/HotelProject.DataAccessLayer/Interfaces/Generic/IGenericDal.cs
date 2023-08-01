using HotelProject.EntityLayer.Abstract;

namespace HotelProject.DataAccessLayer.Interfaces.Generic;

public interface IGenericDal<T> where T : BaseEntity
{
    void Insert(T t);
    void Delete(T t);
    void Update(T t);
    List<T> GetList();
    T GetById(int id);
}
