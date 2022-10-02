using Telluria.Utils.Crud.Entities;

namespace APIDiaristas.Domain.Entities;

public class DayWorker : BaseEntity
{
  public string Name { get; set; }
  public string Email { get; set; }
  public string City { get; set; }
  public string Address { get; set; }
  public string PostCode { get; set; }
  public string CPF { get; set; }
  public string RG { get; set; }
  public string Phone { get; set; }
  public DateOnly BirthDate { get; set; }
  public string PasswordHash { get; set; }
  public bool Active { get; set; } = true;
  public decimal TotalStars { get; set; }
  
}