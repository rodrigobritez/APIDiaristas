using Telluria.Utils.Crud.Entities;

namespace APIDiaristas.Domain.Entities;

public class Client : BaseEntity
{
  public string Name { get; set; }
  public string Email { get; set; }
}