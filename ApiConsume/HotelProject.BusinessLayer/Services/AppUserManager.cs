using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace HotelProject.BusinessLayer.Services;

public class AppUserManager : IAppUserService
{
    private readonly IAppUserDal _appUserDal;

    public AppUserManager(IAppUserDal appUserDal)
    {
        _appUserDal = appUserDal;
    }

    public List<AppUser> TGetList()
    {
        return _appUserDal.TGetList();
    }

    public List<AppUser> TUserListWithWorkLocation()
    {
        return _appUserDal.UserListWithWorkLocation();
    }
}
