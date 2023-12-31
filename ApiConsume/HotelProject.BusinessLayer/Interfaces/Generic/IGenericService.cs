﻿using HotelProject.EntityLayer.Abstract;

namespace HotelProject.BusinessLayer.Interfaces.Generic;

public interface IGenericService<T> where T : class
{
    Task AddAsync(T t);
    Task DeleteAsync(T t);
    Task UpdateAsync(T t);
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
}
