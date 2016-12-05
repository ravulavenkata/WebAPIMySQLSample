using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentValidation;
using WebAPIMySQLSample.Common.ViewModel;

namespace WebAPIMySQLSample.Common.Validators
{
    public class CompanyViewModelValidator : AbstractValidator<CompanyViewModel>
    {
        public CompanyViewModelValidator()
        {
            RuleFor(customer => customer.CompanyName).NotEmpty()
                .Length(1, 100).WithMessage("First Name must be between 1 - 100 characters");

            RuleFor(customer => customer.CompanyAddress).NotEmpty()
                .Length(1, 100).WithMessage("Last Name must be between 1 - 100 characters");

            RuleFor(customer => customer.CompanyCity).NotEmpty()
                .Length(1, 100).WithMessage("City Name must be between 1 - 100 characters");

            //RuleFor(customer => customer.DateOfBirth).NotNull()
            //    .LessThan(DateTime.Now.AddYears(-16))
            //    .WithMessage("Customer must be at least 16 years old.");

            //RuleFor(customer => customer.Mobile).NotEmpty().Matches(@"^\d{10}$")
            //    .Length(10).WithMessage("Mobile phone must have 10 digits");

            //RuleFor(customer => customer.Email).NotEmpty().EmailAddress()
            //    .WithMessage("Enter a valid Email address");

        }
    }
}