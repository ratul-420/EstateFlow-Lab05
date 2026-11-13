using EstateFlow.Application.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace EstateFlow.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Discover all validators and register them in the DI container (with scoped lifetime)
        services.AddValidatorsFromAssemblyContaining<IApplicationDbContext>();
        services.AddScoped<IMeterReadingService, MeterReadingService>();
        return services;
    }
}
