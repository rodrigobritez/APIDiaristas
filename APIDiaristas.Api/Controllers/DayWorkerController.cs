using APIDiaristas.Domain.Commands;
using APIDiaristas.Domain.DTOs;
using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Handlers;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Microsoft.AspNetCore.Mvc;
using Telluria.Utils.Crud.CommandResults;
using Telluria.Utils.Crud.Controllers;

namespace APIDiaristas.Api.Controllers;

public class DayWorkerController : BaseCrudController<DayWorker, DayWorkerValidator, IDayWorkerRepository, IDayWorkerHandler>
{
    [HttpPost("/login")]
    public async Task<ICommandResult<string>> Login(
        [FromBody]LoginDto login,
        [FromServices] IDayWorkerHandler dayWorkerHandler,
        CancellationToken cancellationToken = default)
    {
        return await dayWorkerHandler.HandleAsync(new LoginCommand(login, cancellationToken));
    }
}