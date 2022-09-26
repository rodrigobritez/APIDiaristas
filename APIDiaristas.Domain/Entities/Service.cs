using Telluria.Utils.Crud.Entities;

namespace APIDiaristas.Domain.Entities;

public class Service : BaseEntity
{
  public Guid ClientId { get; set; }
  public Guid DayWorkerId { get; set; }
  public virtual Client Client { get; set; }
  public virtual DayWorker DayWorker { get; set; }
  public string Avaliation { get; set; }
  public int Stars { get; set; }
}