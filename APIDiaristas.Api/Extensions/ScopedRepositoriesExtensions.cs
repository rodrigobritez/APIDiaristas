using APIDiaristas.Data.Repositories;
using APIDiaristas.Domain.Interfaces.Repositories;

namespace APIDiaristas.Api.Extensions;

public static class ScopedRepositoriesExtensions
{
  public static void AddCustomRepositories(this IServiceCollection services)
  {
    services.AddTransient<IClientRepository, ClientRepository>();
    services.AddTransient<IServiceRepository, ServiceRepository>();
    services.AddTransient<IDayWorkerRepository, DayWorkerRepository>();
  }
}
