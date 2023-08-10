using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.Interfaces;

public interface ISendMessageDal : IGenericDal<SendMessage>
{
    public int GetSendMessageCount();
}
