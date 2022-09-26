using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Telluria.Utils.Crud.Repositories;

namespace APIDiaristas.Data.Repositories;

public class ServiceRepository : BaseCrudRepository<Service>, IServiceRepository
{
  public ServiceRepository(DbContext context) : base(context)
  {
  }
}