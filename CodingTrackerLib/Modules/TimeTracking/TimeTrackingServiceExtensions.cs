using CodingTrackerLib.Modules.TimeTracking.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace CodingTrackerLib.Modules.TimeTracking;

public static class TimeTrackingServiceExtensions
{
    public static IServiceCollection AddTimeTracking(this IServiceCollection services)
    {
        services.AddSingleton<AddTrackingCommandHandler>();

        return services;
    }
}