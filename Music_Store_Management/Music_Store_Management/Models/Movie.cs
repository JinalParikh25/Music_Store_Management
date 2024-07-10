using System.ComponentModel.DataAnnotations;

namespace Music_Store_Management.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Release Date field is required.")]
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Required(ErrorMessage = "The field Number in Stock is required.")]
        [Range(1,20, ErrorMessage = "The field Number in stock must be between 1 and 20")]
        public int Stock { get; set; }

        public Genre? Genre { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "The Gerne field is required.")]
        public int GenreId { get; set; }
    }
}
