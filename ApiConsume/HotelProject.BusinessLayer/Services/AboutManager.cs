﻿using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class AboutManager : IAboutService
{
    private readonly IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public void TDelete(About t)
    {
        _aboutDal.Delete(t);
    }

    public About TGetById(int id)
    {
        return _aboutDal.GetById(id);
    }

    public List<About> TGetList()
    {
        return _aboutDal.GetList();
    }

    public void TInsert(About t)
    {
        _aboutDal.Insert(t);
    }

    public void TUpdate(About t)
    {
        _aboutDal.Update(t);
    }
}