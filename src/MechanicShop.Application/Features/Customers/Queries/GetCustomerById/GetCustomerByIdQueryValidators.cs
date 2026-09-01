using FluentValidation;

namespace MechanicShop.Application.Features.Customers.Queries.GetCustomerById;

public class GetCustomerByIdQueryValidators : AbstractValidator<GetCustomerByIdQuery>
{
    public GetCustomerByIdQueryValidators()
    {
        RuleFor(request => request.CustomerId)
            .NotEmpty()
            .WithErrorCode("CustomerId_Is_Required")
            .WithMessage("CustomerId is required.");
    }
}