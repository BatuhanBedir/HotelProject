using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;
public interface IAppUserRepository
{
    List<AppUser> UserListWithWorkLocation();
    List<AppUser> GetList();
}
