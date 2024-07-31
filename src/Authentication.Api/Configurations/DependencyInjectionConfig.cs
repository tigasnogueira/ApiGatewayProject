using Authentication.Api.Extensions;
using Authentication.Api.Interfaces;
using Authentication.Api.Notifications;
using Authentication.Api.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Authentication.Api.Configurations;

public static class DependencyInjectionConfig
{
    public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.TryAddScoped<INotifier, Notifier>();
        services.TryAddScoped<IAspNetUser, AspNetUser>();
        services.TryAddScoped<IAuthService, AuthService>();
        services.TryAddScoped<RoleManager<IdentityRole>>();
        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddAuthorization();
    }
}