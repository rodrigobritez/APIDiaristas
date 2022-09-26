using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Handlers;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Telluria.Utils.Crud.CommandResults;
using Telluria.Utils.Crud.Handlers;

namespace APIDiaristas.Domain.Handlers;

public class ClientHandler : BaseCrudCommandHandler<Client, ClientValidator, IClientRepository>, IClientHandler
{
  public ClientHandler(IClientRepository repository) : base(repository)
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
      EBaseCrudCommands.CREATE => "Cliente criado com sucesso!",
      EBaseCrudCommands.UPDATE => "Cliente atualizado com sucesso!",
      EBaseCrudCommands.SOFT_DELETE => "Cliente deletado com sucesso!",
      EBaseCrudCommands.REMOVE => "Cliente removido com sucesso!",
      _ => GetDefaultSuccessMessage(command)
    };
  }
}