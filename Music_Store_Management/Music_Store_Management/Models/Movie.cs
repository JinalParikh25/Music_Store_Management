﻿namespace Music_Store_Management.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int Stock { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
