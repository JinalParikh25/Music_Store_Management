using Microsoft.AspNetCore.Mvc;
using Music_Store_Management.Models;
using Music_Store_Management.Services;
using Music_Store_Management.ViewModels;

namespace Music_Store_Management.Controllers
{
    public class CustomerController : Controller
    {
        RandomViewModel randomViewModel = new RandomViewModel();
        GetCustomerListServices getCustomerListServices = new GetCustomerListServices();
        public IActionResult Index()
        {
            randomViewModel.CustomerList = getCustomerListServices.GetCustomers();
           
            return View(randomViewModel);
        }

        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
                Customer customer = getCustomerListServices.GetCustomers().FirstOrDefault(x => x.Id == id);

                if (customer == null)
                {
                    throw new Exception("NotFound");
                }

                return View(customer);
        }
    }
}
