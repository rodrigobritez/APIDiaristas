using APIDiaristas.Domain.Entities;
using FluentValidation;
using Telluria.Utils.Crud.Validation;

namespace APIDiaristas.Domain.Validators;

public class ClientValidator : BaseEntityValidator<Client>
{
  public ClientValidator()
  {
    void UpsertRuleSet()
    {
      RuleFor(x => x.Name).NotEmpty().WithMessage("The name of the client is required");
      RuleFor(x => x.Id).NotEmpty().WithMessage("The id of the client is required");
      RuleFor(x => x.Email).NotEmpty().WithMessage("The email of the client is required");
    }

    AddBaseRuleCreate(UpsertRuleSet);
    AddBaseRuleUpdate(UpsertRuleSet);
  }
}
