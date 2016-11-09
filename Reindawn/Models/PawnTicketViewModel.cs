using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Reindawn.Domain.Enumerations;

namespace Reindawn.Models
{
    public class PawnTicketViewModel
    {
        public Guid Id { get; set; }

        public PawnTicketTypeEnum PawnTicketType { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateLoanGranted { get; set; }
        [DataType(DataType.Date)]
        public DateTime MaturityDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }
        [DataType(DataType.Date)]
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