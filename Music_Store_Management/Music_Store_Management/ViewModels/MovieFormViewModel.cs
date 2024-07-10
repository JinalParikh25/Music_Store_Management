using Music_Store_Management.Models;
using System.ComponentModel.DataAnnotations;

namespace Music_Store_Management.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required(ErrorMessage = "The field Number in Stock is required.")]
        [Range(1, 20, ErrorMessage = "The field Number in stock must be between 1 and 20")]
        public int? Stock { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "The Gerne field is required.")]
        public int? GenreId { get; set; }
        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
                Id = movie.Id;
                Name = movie.Name;
                ReleaseDate = movie.ReleaseDate;
                Stock = movie.Stock;
            GenreId = movie.GenreId;
        }
    }
}

