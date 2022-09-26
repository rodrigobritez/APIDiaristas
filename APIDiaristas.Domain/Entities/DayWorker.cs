using Telluria.Utils.Crud.Entities;

namespace APIDiaristas.Domain.Entities;

public class DayWorker : BaseEntity
{
  public string Name { get; set; }
  public string Email { get; set; }
  public string Region { get; set; }
  public string CPF { get; set; }
  public string RG { get; set; }
  public bool Active { get; set; } = true;
  public decimal ServiceValue { get; set; }
  public decimal TotalStars { get; set; }
  
}