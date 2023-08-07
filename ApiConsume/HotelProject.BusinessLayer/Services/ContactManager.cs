using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public void TDelete(Contact t)
    {
        _contactDal.Delete(t);
    }

    public Contact TGetById(int id)
    {
        return _contactDal.GetById(id);
    }

    public List<Contact> TGetList()
    {
        return _contactDal.GetList();
    }

    public void TInsert(Contact t)
    {
        _contactDal.Insert(t);
    }

    public void TUpdate(Contact t)
    {
        _contactDal.Update(t);
    }
}
