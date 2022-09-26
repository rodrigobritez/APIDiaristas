using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Handlers;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Telluria.Utils.Crud.CommandResults;
using Telluria.Utils.Crud.Handlers;

namespace APIDiaristas.Domain.Handlers;

public class DayWorkerHandler : BaseCrudCommandHandler<DayWorker, DayWorkerValidator, IDayWorkerRepository>, IDayWorkerHandler
{
  public DayWorkerHandler(IDayWorkerRepository repository) : base(repository)
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
      EBaseCrudCommands.CREATE => "Diarista criado com sucesso!",
      EBaseCrudCommands.UPDATE => "Diarista atualizado com sucesso!",
      EBaseCrudCommands.SOFT_DELETE => "Diarista deletado com sucesso!",
      EBaseCrudCommands.REMOVE => "Diarista removido com sucesso!",
      _ => GetDefaultSuccessMessage(command)
    };
  }
}