using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Telluria.Utils.Crud.Repositories;

namespace APIDiaristas.Data.Repositories;

public class ClientRepository : BaseCrudRepository<Client>, IClientRepository
{
  public ClientRepository(DbContext context) : base(context)
  {
  }
}