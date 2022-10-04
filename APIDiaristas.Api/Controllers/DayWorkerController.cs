using APIDiaristas.Domain.Commands;
using APIDiaristas.Domain.DTOs;
using APIDiaristas.Domain.Entities;
using APIDiaristas.Domain.Interfaces.Handlers;
using APIDiaristas.Domain.Interfaces.Repositories;
using APIDiaristas.Domain.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Telluria.Utils.Crud.CommandResults;
using Telluria.Utils.Crud.Controllers;

namespace APIDiaristas.Api.Controllers;

[AllowAnonymous]
public class DayWorkerController : BaseCrudController<DayWorker, DayWorkerValidator, IDayWorkerRepository, IDayWorkerHandler>
{
    
    [HttpPost("/login")]
    [AllowAnonymous]
    public async Task<ICommandResult<string>> Login(
        [FromBody]LoginDto login,
        [FromServices] IDayWorkerHandler dayWorkerHandler,
        CancellationToken cancellationToken = default)
    {
        return await dayWorkerHandler.HandleAsync(new LoginCommand(login, cancellationToken));
        
    }
    [HttpGet("cep/{address}")]
    [AllowAnonymous]
    public async Task<ICommandResult<IEnumerable<DayWorker>>> GetByPostCode(
        string address,
        [FromServices] IDayWorkerHandler dayWorkerHandler,
        CancellationToken cancellationToken = default)
    {
        return await dayWorkerHandler.HandleAsync(new GetPostCodeCommand(address, cancellationToken));
    }
}