using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Handlers;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Telluria.Utils.Crud.Controllers;

namespace APIDiaristas.Api.Controllers;

public class ServiceController : BaseCrudController<Service, ServiceValidator, IServiceRepository, IServiceHandler>
{
}