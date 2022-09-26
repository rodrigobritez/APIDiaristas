using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Telluria.Utils.Crud.Repositories;

namespace APIDiaristas.Data.Repositories;

public class DayWorkerRepository : BaseCrudRepository<DayWorker>, IDayWorkerRepository
{
  public DayWorkerRepository(DbContext context) : base(context)
  {
  }
}