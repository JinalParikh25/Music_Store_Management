using System.ComponentModel.DataAnnotations;

namespace Music_Store_Management.Models
{
    public class Min18yearsIfMembers : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if(customer.MembershipTypeId == MembershipType.unknown || customer.MembershipTypeId == MembershipType.payAsYouGo)
            {
               return ValidationResult.Success;
            }

            if (customer.BirthDate == null) {
                return new ValidationResult("Birthdate is required");
            }

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return age > 18 ? ValidationResult.Success : new ValidationResult("Customer at least 18 years old");
        }
    }
}
