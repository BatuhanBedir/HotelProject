using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;
public interface IAppUserDal
{
    List<AppUser> UserListWithWorkLocation();
    List<AppUser> TGetList();
}
