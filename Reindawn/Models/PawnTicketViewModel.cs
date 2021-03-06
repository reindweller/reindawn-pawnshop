﻿using System;
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
        public string PawnTicketNo { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Loan Granted")]
        public DateTime DateLoanGranted { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Maturity Date")]
        public DateTime MaturityDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Expiration Date")]
        public DateTime ExpirationDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Auction Sale")]
        public DateTime AuctionSale { get; set; }
        public Guid SignatureCardId { get; set; }
        public SignatureCardViewModel SignatureCard { get; set; }

        public Guid AppraisersSlipId { get; set; }
        public AppraisersSlipViewModel AppraisersSlip { get; set; }
        public decimal Amount { get; set; }
        public decimal Interest { get; set; }
        public decimal ServiceCharge { get; set; }
        public decimal Description { get; set; }


        [Display(Name = "Prefix")]
        public NamePrefixEnum NamePrefix { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string FullName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }

        public decimal Principal { get; set; }
    }
}