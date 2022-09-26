using APIDiaristas.Domain.Handlers;
using APIDiaristas.Domain.Interfaces.Handlers;

namespace APIDiaristas.Api.Extensions;

public static class ScopedHandlersExtensions
{
  public static void AddCustomHandlers(this IServiceCollection services)
  {
    services.AddTransient<IClientHandler, ClientHandler>();
    services.AddTransient<IServiceHandler, ServiceHandler>();
    services.AddTransient<IDayWorkerHandler, DayWorkerHandler>();
  }
}