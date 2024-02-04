using Application.Services;
using Domain.InterfacesServices;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ModuleDependency
{
    public static void AddApplicationModule(this IServiceCollection service)
    {
        service.AddTransient<ISlideService, SlideService>();
    }
}
