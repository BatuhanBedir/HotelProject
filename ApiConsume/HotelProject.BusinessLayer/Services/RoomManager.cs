using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class RoomManager : IRoomService
{
    private readonly IRoomDal _roomDal;

    public RoomManager(IRoomDal roomDal)
    {
        _roomDal = roomDal;
    }

    public void TDelete(Room t)
    {
        _roomDal.Delete(t);
    }

    public Room TGetById(int id)
    {
        return _roomDal.GetById(id);
    }

    public List<Room> TGetList()
    {
       return _roomDal.GetList();
    }

    public void TInsert(Room t)
    {
        _roomDal.Insert(t);
    }

    public void TUpdate(Room t)
    {
        _roomDal.Update(t);
    }
}
