using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfContactDal : GenericRepository<Contact>, IContactDal
{
    private readonly Context _context;
    public EfContactDal(Context context) : base(context)
    {
        _context = context;
    }

    public int GetContactCount()
    {
        return _context.Contacts.Count();
    }
}
