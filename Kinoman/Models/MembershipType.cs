using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kinoman.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public short SignUpFee { get; set; }
        [Required]
        public byte DurationInMonths { get; set; }
        [Required]
        public byte DiscountRate { get; set; }
    }
}