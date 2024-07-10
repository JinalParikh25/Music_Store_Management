using System.ComponentModel.DataAnnotations;

namespace Music_Store_Management.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name ="Date of Birth")]
        [Min18yearsIfMembers]
        public DateOnly? BirthDate { get; set; }
        public MembershipType? MembershipType { get; set; }

        [Display(Name="Membership Type")]
        public Byte MembershipTypeId { get; set; }
    }
}
