﻿using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;

public class BookingManager : IBookingService
{
    private readonly IBookingDal _bookingDal;

    public BookingManager(IBookingDal bookingDal)
    {
        _bookingDal = bookingDal;
    }
    public void TBookingStatusChangeApproved(int id)
    {
        _bookingDal.BookingStatusChangeApproved(id);
    }

    public void TDelete(Booking t)
    {
        _bookingDal.Delete(t);
    }

    public Booking TGetById(int id)
    {
        return _bookingDal.GetById(id);
    }

    public List<Booking> TGetList()
    {
        return _bookingDal.GetList();
    }

    public void TInsert(Booking t)
    {
        _bookingDal.Insert(t);
    }

    public void TUpdate(Booking t)
    {
        _bookingDal.Update(t);
    }
}
