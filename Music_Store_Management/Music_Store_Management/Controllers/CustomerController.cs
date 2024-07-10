using Microsoft.AspNetCore.Mvc;
using Music_Store_Management.Models;
using Music_Store_Management.Services;
using Music_Store_Management.ViewModels;
using Music_Store_Management.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult New()
        {
            List<MembershipType> membershipTypes_list =  _context.MembershipTypes.ToList();

            CustomerViewModel customerViewModel = new CustomerViewModel()
            {
                MembershipTypes = membershipTypes_list,
                Customer = new Customer(),
            };
            
            return View("CustomerForm",customerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitForm(Customer customer) {

            if (!ModelState.IsValid)
            {
                CustomerViewModel customerViewModel = new CustomerViewModel()
                {
                    Customer = customer,
                    MembershipTypes= _context.MembershipTypes.ToList(),
                };

                ModelState.AddModelError("", "Please fix following errors!");
                return View("CustomerForm", customerViewModel);
            }
            if (customer.Id != 0)
            {
                _context.Customers.Update(customer);
            }
            else
            {
                _context.Customers.Add(customer);
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) {
           
            CustomerViewModel customerViewModel = new CustomerViewModel
            {
                Customer = _context.Customers.FirstOrDefault(x => x.Id == id),
                MembershipTypes = _context.MembershipTypes,

            };

            return View("CustomerForm", customerViewModel);
        }

    }
}
