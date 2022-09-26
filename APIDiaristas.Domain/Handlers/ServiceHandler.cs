using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Handlers;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Telluria.Utils.Crud.CommandResults;
using Telluria.Utils.Crud.Handlers;

namespace APIDiaristas.Domain.Handlers;

public class ServiceHandler : BaseCrudCommandHandler<Service, ServiceValidator, IServiceRepository>, IServiceHandler
{
  public ServiceHandler(IServiceRepository repository) : base(repository)
  {
  }

  protected override ICommandResult HandleErrors(Exception exception)
  {
    var result = GetDefaultError(exception);
    return result;
  }

  protected override string GetSuccessMessage(EBaseCrudCommands command)
  {
    return command switch
    {
      EBaseCrudCommands.CREATE => "Serviço criado com sucesso!",
      EBaseCrudCommands.UPDATE => "Serviço atualizado com sucesso!",
      EBaseCrudCommands.SOFT_DELETE => "Serviço deletado com sucesso!",
      EBaseCrudCommands.REMOVE => "Serviço removido com sucesso!",
      _ => GetDefaultSuccessMessage(command)
    };
  }
}