using Telluria.Utils.Crud.Commands;

namespace APIDiaristas.Domain.Commands;

public class GetPostCodeCommand : ICommand
{
    public GetPostCodeCommand(string city, CancellationToken cancellationToken)
    {
        City = city;
        CancellationToken = cancellationToken;
    }

    public string City { get; set; }
    public CancellationToken CancellationToken { get; set; }
}