using FluentValidation;
using TechLibrary.Communication.Requests;
namespace TechLibrary.Api.UseCases.Users.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestUserJson>
    {
        public RegisterUserValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(request => request.Email).EmailAddress().WithMessage("Email is invalid");
            When(request => string.IsNullOrEmpty( request.Password) == false, () =>
            {
                RuleFor(request => request.Password).MinimumLength(6).WithMessage("Password must be at least 6 characters");
            });
        }
    }
    
 }
