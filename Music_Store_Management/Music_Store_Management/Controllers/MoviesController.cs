using Microsoft.AspNetCore.Mvc;
using Music_Store_Management.Models;
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

            return View(movie);
        }

        public IActionResult Edit(int id) 
        {
            return Content("id="+  id);
        }

        public IActionResult ByReleaseDate(int year,int month) {

            return Content(string.Format("year={0}&month={1}", year,month));
        }
    }
}
