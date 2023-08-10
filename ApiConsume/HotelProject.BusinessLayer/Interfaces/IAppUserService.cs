using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;
public interface IAppUserService
{
    List<AppUser> TUserListWithWorkLocation();
    List<AppUser> TGetList();

}
