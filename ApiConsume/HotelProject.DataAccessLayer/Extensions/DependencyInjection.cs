using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.DataAccessLayer.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelProject.DataAccessLayer.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddEFCoreServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IRoomRepository, EfRoomRepository>();
        services.AddScoped<ITestimonialRepository, EfTestimonialRepository>();
        services.AddScoped<ISubscribeRepository, EfSubscribeRepository>();
        services.AddScoped<IStaffRepository, EfStaffRepository>();
        services.AddScoped<IServiceRepository, EfServiceRepository>();
        services.AddScoped<IAboutRepository, EfAboutRepository>();
        services.AddScoped<IBookingRepository, EfBookingRepository>();
        services.AddScoped<IContactRepository, EfContactRepository>();
        services.AddScoped<IGuestRepository, EfGuestRepository>();
        services.AddScoped<ISendMessageRepository, EfSendMessageRepository>();
        services.AddScoped<ICategoryRepository, EfCategoryRepository>();
        services.AddScoped<IWorkLocationRepository, EfWorkLocationRepository>();
        services.AddScoped<IAppUserRepository, EfAppUserRepository>();

        return services;
    }
}
