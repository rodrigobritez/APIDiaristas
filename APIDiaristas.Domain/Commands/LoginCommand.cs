using APIDiaristas.Domain.DTOs;
using APIDiaristas.Domain.Entities;
using Telluria.Utils.Crud.Commands;

namespace APIDiaristas.Domain.Commands;

public class LoginCommand : ICommand
{
    public LoginCommand(LoginDto loginDto, CancellationToken cancellationToken)
    {
        LoginDto = loginDto;
        CancellationToken = cancellationToken;
    }

    public LoginDto LoginDto { get; set; }
    public CancellationToken CancellationToken { get; set; }
}