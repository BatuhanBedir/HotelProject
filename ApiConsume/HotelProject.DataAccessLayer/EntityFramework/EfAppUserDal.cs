using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfAppUserDal : IAppUserDal
{
    private readonly Context _context;

    public EfAppUserDal(Context context)
    {
        _context = context;
    }

    public List<AppUser> TGetList()
    {
        return _context.Users.ToList();
    }

    public List<AppUser> UserListWithWorkLocation()
    {
        return _context.Users.Include(x => x.WorkLocation).ToList();
    }
}
