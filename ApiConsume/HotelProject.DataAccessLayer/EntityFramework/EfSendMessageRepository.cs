using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfSendMessageRepository : GenericRepository<SendMessage>, ISendMessageRepository
{
    public EfSendMessageRepository(Context context) : base(context)
    {
        
    }
}
