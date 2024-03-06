﻿using FluentValidation;
namespace FirstAppWebAPI.Models
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty();
            RuleFor(customer => customer.Email).EmailAddress();
            // Other rules
        }
    }
}
