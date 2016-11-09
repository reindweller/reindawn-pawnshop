using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reindawn.Domain.Enumerations;

namespace Reindawn.Domain.Models
{
    public class PawnTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }


        public PawnTicketTypeEnum PawnTicketType { get; set; }

        public DateTime DateLoanGranted { get; set; }
        public DateTime MaturityDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime AuctionSale { get; set; }

        
        public NamePrefixEnum Prefix { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public string Address { get; set; }
        public decimal Principal { get; set; }
        public decimal Interest { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal Description { get; set; }
    }
}
