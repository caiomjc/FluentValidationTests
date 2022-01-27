using FluentValidation;
using FluentValidationTests.Entities;

namespace FluentValidationTests.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Id).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(customer => customer.Name).NotNull().NotEmpty();
            RuleFor(customer => customer.Discount).LessThanOrEqualTo(20).WithMessage("Discount can't be greater than 20."); ;
        }
    }
}
