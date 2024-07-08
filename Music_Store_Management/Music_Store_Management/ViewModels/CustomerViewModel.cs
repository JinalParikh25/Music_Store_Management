using Microsoft.AspNetCore.Mvc.Rendering;
using Music_Store_Management.Models;

namespace Music_Store_Management.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}
