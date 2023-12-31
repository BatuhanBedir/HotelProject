﻿using HotelProject.BusinessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Interfaces;

public interface ISendMessageService : IGenericService<SendMessage>
{
    public Task<int> GetSendMessageCountAsync();

}
