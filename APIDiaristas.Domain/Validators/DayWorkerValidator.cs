using APIDiaristas.Domain.Entities;
using FluentValidation;
using Telluria.Utils.Crud.Validation;

namespace APIDiaristas.Domain.Validators;

public class DayWorkerValidator : BaseEntityValidator<DayWorker>
{
  public DayWorkerValidator()
  {
    void UpsertRuleSet()
    {
      RuleFor(x => x.Name).NotEmpty().WithMessage("The name of the day worker is required");
      RuleFor(x => x.Id).NotEmpty().WithMessage("The id of the day worker is required");
      RuleFor(x => x.Email).NotEmpty().WithMessage("The email of the day worker is required");
    }

    AddBaseRuleCreate(UpsertRuleSet);
    AddBaseRuleUpdate(UpsertRuleSet);
  }
}