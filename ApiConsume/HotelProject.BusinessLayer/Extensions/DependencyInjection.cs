using HotelProject.BusinessLayer.Interfaces;
using HotelProject.BusinessLayer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HotelProject.BusinessLayer.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IStaffService, StaffManager>();
        services.AddScoped<IRoomService, RoomManager>();
        services.AddScoped<IServiceService, ServiceManager>();
        services.AddScoped<ISubscribeService, SubscribeManager>();
        services.AddScoped<ITestimonialService, TestimonialManager>();
        services.AddScoped<IAboutService, AboutManager>();

        return services;
    }
}
