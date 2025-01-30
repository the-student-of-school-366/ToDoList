using Microsoft.Extensions.DependencyInjection;

namespace BuisnessLogic;

public static class Extensions
{
    public static IServiceCollection AddBuisnessLogic(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<INoteService, NoteService>();
        return serviceCollection;
    }
}