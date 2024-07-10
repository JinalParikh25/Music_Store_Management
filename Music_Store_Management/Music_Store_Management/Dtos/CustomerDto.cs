using Music_Store_Management.Models;
using System.ComponentModel.DataAnnotations;

namespace Music_Store_Management.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Min18yearsIfMembers]
        public DateOnly? BirthDate { get; set; }
       
        public Byte MembershipTypeId { get; set; }
    }
}
