using APIDiaristas.Data.Services;
using APIDiaristas.Domain.Commands;
using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Handlers;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Telluria.Utils.Crud.CommandResults;
using Telluria.Utils.Crud.Handlers;

namespace APIDiaristas.Domain.Handlers;

public class DayWorkerHandler : BaseCrudCommandHandler<DayWorker, DayWorkerValidator, IDayWorkerRepository>, IDayWorkerHandler
{
  private readonly TokenService _tokenService;
  public DayWorkerHandler(IDayWorkerRepository repository, TokenService tokenService) : base(repository)
  {
    _tokenService = tokenService;
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

  public async Task<ICommandResult<string>> HandleAsync(LoginCommand command)
  {
    var dayWorkerLogin = await _repository.FindAsync(false, x => x.Email == command.LoginDto.Email, null, command.CancellationToken);

    if (dayWorkerLogin == null)
    {
      return new CommandResult<string>(
        ECommandResultStatus.ERROR,
        "Usuário ou senha invalidos!",
        null);
    }

    if (dayWorkerLogin.PasswordHash != command.LoginDto.Password)
    {
      return new CommandResult<string>(
        ECommandResultStatus.ERROR,
        "Usuário ou senha invalidos!",
        null);
    }
    
    var token = _tokenService.GenerateToken(command.LoginDto);
      
    return new CommandResult<string>(
      ECommandResultStatus.SUCCESS,
      "Token gerado com sucesso!",
      token);
  }
}