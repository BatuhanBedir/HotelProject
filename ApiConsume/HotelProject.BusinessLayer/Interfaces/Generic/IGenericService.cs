using HotelProject.EntityLayer.Abstract;

namespace HotelProject.BusinessLayer.Interfaces.Generic;

public interface IGenericService<T> where T : class
{
    void TInsert(T t);
    void TDelete(T t);
    void TUpdate(T t);
    List<T> TGetList();
    T TGetById(int id);
}
