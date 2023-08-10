using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces.Generic;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void TDelete(Category t)
    {
        _categoryDal.Delete(t);
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public List<Category> TGetList()
    {
        return _categoryDal.GetList();
    }

    public void TInsert(Category t)
    {
        _categoryDal.Insert(t);
    }

    public void TUpdate(Category t)
    {
        _categoryDal.Update(t);
    }
}
