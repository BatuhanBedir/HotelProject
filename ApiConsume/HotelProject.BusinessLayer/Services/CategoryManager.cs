using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryManager(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task AddAsync(Category t)
    {
        await _categoryRepository.AddAsync(t);
        await _categoryRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(Category t)
    {
        await _categoryRepository.DeleteAsync(t);
        await _categoryRepository.SaveChangesAsync();
    }

    public async Task<List<Category>> GetAllAsync()
    {
        return await _categoryRepository.GetAllAsync();
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        return await _categoryRepository.GetByIdAsync(id);
    }

    public async Task UpdateAsync(Category t)
    {
        await _categoryRepository.UpdateAsync(t);
        await _categoryRepository.SaveChangesAsync();
    }
}
