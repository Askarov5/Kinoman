using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Kinoman.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(255)]
        public string Lastname { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}