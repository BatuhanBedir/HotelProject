using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class RoomManager : IRoomService
{
    private readonly IRoomDal _roomDal;
    private readonly IAboutDal _aboutDal;

    public RoomManager(IRoomDal roomDal, IAboutDal aboutDal)
    {
        _roomDal = roomDal;
        _aboutDal = aboutDal;
    }

    public void TDelete(Room t)
    {
        _roomDal.Delete(t);
        var a = _aboutDal.GetList();
        foreach (var item in a)
        {
            item.RoomCount--;
            _aboutDal.Update(item);
        }
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
        List<About>? a = _aboutDal.GetList();
        foreach (var item in a)
        {
            item.RoomCount++;
            _aboutDal.Update(item);
        }
    }

    public int TRoomCount()
    {
        return _roomDal.GetList().Count();
    }

    public void TUpdate(Room t)
    {
        _roomDal.Update(t);
    }
}
