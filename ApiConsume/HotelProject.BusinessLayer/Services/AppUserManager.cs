using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.DtoLayer.Dtos.AppUserDto;
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

    public int TAppUserCount()
    {
        return _appUserDal.GetList().Count();
    }

    public List<AppUser> TGetList()
    {
        return _appUserDal.GetList();
    }
    public List<AppUserWorkLocationDto> TUserListWorkLocation()
    {
        return _appUserDal.UserListWithWorkLocation().Select(x => new AppUserWorkLocationDto
        {
            Name = x.Name,
            Surname = x.Surname,
            ImageUrl = x.ImageUrl,
            City = x.City,
            Country = x.Country,
            Gender = x.Gender,
            WorkLocationId = x.WorkLocationId,
            WorkLocationName = x.WorkLocation.Name
        }).ToList();
    }
}
