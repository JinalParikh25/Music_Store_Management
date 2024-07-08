using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Music_Store_Management.context;
using Music_Store_Management.Models;
using Music_Store_Management.ViewModels;
using System.Globalization;

namespace Music_Store_Management.Controllers
{
    public class MoviesController : Controller
    {
        private MusicStoreContext _context;

        public MoviesController(MusicStoreContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Movie> movies = _context.Movies.Include(m => m.Genre).ToList();  
            return View(movies);
        }

        public IActionResult Details(int id)
        {
            Movie movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Id == id);
            return View(movie);
        }
        //public IActionResult Random() {

        //    Movie movie = new Movie()
        //    {
        //        Name = "Shrank!"
        //    };

        //    List<Customer> customer = new List<Customer>
        //    {
        //        new Customer{  Name = "xyz" },
        //        new Customer { Name = "abc"}
        //    };

        //    RandomViewModel randomViewModel = new RandomViewModel()
        //    {
        //        Movie = movie,
        //        CustomerList = customer,
        //    };

        //    return View(randomViewModel);
        //}

        //public IActionResult Edit(int id) 
        //{
        //    return Content("id="+  id);
        //}

        //public IActionResult ByReleaseDate(int year,int month) {

        //    return Content(string.Format("year={0}&month={1}", year,month));
        //}
    }
}
