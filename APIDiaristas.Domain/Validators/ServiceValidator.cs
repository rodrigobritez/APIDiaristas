using APIDiaristas.Domain.Entities;
using FluentValidation;
using Telluria.Utils.Crud.Validation;

namespace APIDiaristas.Domain.Validators;

public class ServiceValidator : BaseEntityValidator<Service>
{
  public ServiceValidator()
  {
    void UpsertRuleSet()
    {
      RuleFor(x => x.Id).NotEmpty().WithMessage("The id of the client is required");
    }

    AddBaseRuleCreate(UpsertRuleSet);
    AddBaseRuleUpdate(UpsertRuleSet);
  }
}