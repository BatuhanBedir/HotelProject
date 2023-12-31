﻿using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework.Generic;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfServiceRepository : GenericRepository<Service>,IServiceRepository
{
    public EfServiceRepository(Context context) : base(context)
    {
    }
}
