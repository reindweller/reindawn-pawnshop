using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reindawn.Models
{
    public class RenewViewModel
    {
        [Display(Name = "Pawn Ticket No.")]
        public string PawnTicketNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Renewed")]
        public DateTime Date { get; set; }
        [Display(Name = "Select Pawn Ticket No.")]
        public Guid PawnTicketId { get; set; }
        public List<SelectListItem> PawnTicketsSelectListItems { get; set; }
    }
}