using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reindawn.Domain.Enumerations;

namespace Reindawn.Models
{
    public class SignatureCardViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Pawn Ticket Number")]
        public string PawnTicketNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public NamePrefixEnum NamePrefix { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        [Display(Name = "Land Line")]
        public string Phone { get; set; }
    }
}