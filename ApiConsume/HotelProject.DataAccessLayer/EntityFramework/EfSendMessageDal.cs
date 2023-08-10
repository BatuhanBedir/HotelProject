using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfSendMessageDal : GenericRepository<SendMessage>, ISendMessageDal
{
    private readonly Context _context;

    public EfSendMessageDal(Context context) : base(context)
    {
        _context = context;
    }

    public int GetSendMessageCount()
    {
        return _context.SendMessages.Count();
    }
}
