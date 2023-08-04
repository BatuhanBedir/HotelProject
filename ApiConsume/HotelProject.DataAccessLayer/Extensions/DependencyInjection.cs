using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelProject.DataAccessLayer.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddEFCoreServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IRoomDal, EfRoomDal>();
        services.AddScoped<ITestimonialDal, EfTestimonialDal>();
        services.AddScoped<ISubscribeDal, EfSubscribeDal>();
        services.AddScoped<IStaffDal, EfStaffDal>();
        services.AddScoped<IServiceDal, EfServiceDal>();
        services.AddScoped<IAboutDal, EfAboutDal>();

        return services;
    }
}
