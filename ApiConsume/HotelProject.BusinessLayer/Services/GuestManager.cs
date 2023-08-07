using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class GuestManager : IGuestService
{
    private readonly IGuestDal _guestDal;
    private readonly IAboutDal _aboutDal;


    public GuestManager(IGuestDal guestDal, IAboutDal aboutDal)
    {
        _guestDal = guestDal;
        _aboutDal = aboutDal;
    }

    public void TDelete(Guest t)
    {
        _guestDal.Delete(t);
        var a = _aboutDal.GetList();
        foreach (var item in a)
        {
            item.StaffCount--;
            _aboutDal.Update(item);
        }
    }

    public Guest TGetById(int id)
    {
        return _guestDal.GetById(id);
    }

    public List<Guest> TGetList()
    {
        return _guestDal.GetList();
    }

    public void TInsert(Guest t)
    {
        _guestDal.Insert(t);
        List<About>? a = _aboutDal.GetList();

        foreach (var item in a)
        {
            item.StaffCount++;
            _aboutDal.Update(item);
        }
    }

    public void TUpdate(Guest t)
    {
        _guestDal.Update(t);
    }
}
