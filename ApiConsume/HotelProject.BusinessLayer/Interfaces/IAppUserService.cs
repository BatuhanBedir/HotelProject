using HotelProject.DtoLayer.Dtos.AppUserDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;
public interface IAppUserService
{
    List<AppUserWorkLocationDto> TUserListWorkLocation();
    List<AppUser> TGetList();
    int TAppUserCount();
}
