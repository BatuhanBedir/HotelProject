using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;

public interface IRoomService : IGenericService<Room>
{
    Task<int> RoomCountAsync();
}
