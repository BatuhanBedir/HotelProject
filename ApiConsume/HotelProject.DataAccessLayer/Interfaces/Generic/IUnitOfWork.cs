namespace HotelProject.DataAccessLayer.Interfaces.Generic;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}
