using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Telluria.Utils.Crud.Handlers;

namespace APIDiaristas.Domain.Interfaces.Handlers;

public interface IServiceHandler : IBaseCrudCommandHandler<Service, ServiceValidator, IServiceRepository>
{
  
}