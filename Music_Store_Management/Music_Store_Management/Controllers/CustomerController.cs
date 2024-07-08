using Microsoft.AspNetCore.Mvc;
using Music_Store_Management.Models;
using Music_Store_Management.Services;
using Music_Store_Management.ViewModels;
using Music_Store_Management.context;
using Microsoft.EntityFrameworkCore;

namespace Music_Store_Management.Controllers
{
    public class CustomerController : Controller
    {
        private MusicStoreContext _context;

        public CustomerController(MusicStoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Customer> customer_List = _context.Customers.Include(c => c.MembershipType).ToList();
           
            return View(customer_List);
        }

        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
                Customer customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(x => x.Id == id);

                if (customer == null)
                {
                    throw new Exception("NotFound");
                }

                return View(customer);
        }
    }
}
