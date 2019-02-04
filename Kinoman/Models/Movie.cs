using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kinoman.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate  { get; set; }

        public DateTime? DateAdded { get; set; }

        [Display(Name="Quantity in Stock")]
        public short NumberInStock { get; set; }

        [Display(Name="Short Description")]
        public string ShortDecription { get; set; }
    }
}