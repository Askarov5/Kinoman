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

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate  { get; set; }

        [Display(Name = "Added Date")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        [Display(Name="Quantity in Stock")]
        public short NumberInStock { get; set; }

        [Display(Name="Short Description")]
        public string ShortDecription { get; set; }
    }
}