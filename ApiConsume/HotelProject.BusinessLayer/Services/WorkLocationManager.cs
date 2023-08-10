using HotelProject.BusinessLayer.Interfaces;
using HotelProject.DataAccessLayer.Interfaces;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Services;
public class WorkLocationManager : IWorkLocationService
{
    private readonly IWorkLocationDal _workLocationDal;

    public WorkLocationManager(IWorkLocationDal workLocationDal)
    {
        _workLocationDal = workLocationDal;
    }

    public void TDelete(WorkLocation t)
    {
        _workLocationDal.Delete(t);
    }

    public WorkLocation TGetById(int id)
    {
        return _workLocationDal.GetById(id);
    }

    public List<WorkLocation> TGetList()
    {
        return _workLocationDal.GetList();
    }

    public void TInsert(WorkLocation t)
    {
        _workLocationDal.Insert(t);
    }

    public void TUpdate(WorkLocation t)
    {
        _workLocationDal.Update(t);
    }
}
