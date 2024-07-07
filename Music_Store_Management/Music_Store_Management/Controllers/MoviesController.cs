using Microsoft.AspNetCore.Mvc;
using Music_Store_Management.Models;
using Music_Store_Management.ViewModels;
using System.Globalization;

namespace Music_Store_Management.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&SortBy={1}", pageIndex, sortBy));
        }

        public IActionResult Random() {

            Movie movie = new Movie()
            {
                Name = "Shrank!"
            };

            List<Customer> customer = new List<Customer>
            {
                new Customer{  Name = "xyz" },
                new Customer { Name = "abc"}
            };

            RandomViewModel randomViewModel = new RandomViewModel()
            {
                Movie = movie,
                CustomerList = customer,
            };

            return View(randomViewModel);
        }

        public IActionResult Edit(int id) 
        {
            return Content("id="+  id);
        }

        [Route("movies/released/{year}/{month:regex(^\\d{{2}}):range(1,12)}")]
        public IActionResult ByReleaseDate(int year,int month) {

            return Content(string.Format("year={0}&month={1}", year,month));
        }
    }
}
