using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Reindawn.Domain.Enumerations;

namespace Reindawn.Models
{
    public class AppraisersSlipViewModel
    {
        public Guid Id { get; set; }
        public Guid SignatureCardId { get; set; }
        [Display(Name = "Client Name")]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public decimal? Quantity { get; set; }
        public string Details { get; set; }
        public string Remarks { get; set; }


        //Item
        public Guid ItemId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        [Display(Name = "Item Type")]
        public ItemTypeEnum ItemType { get; set; }
        //jewelry
        public decimal Weight { get; set; }

        [Display(Name = "JewelryType Type")]
        public JewelryTypeEnum JewelryType { get; set; }
        public double Carat { get; set; }

        //gadget
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Inclusions { get; set; }
        [Display(Name = "Serial No.")]
        public string SerialNo { get; set; }
        public string Name { get; set; }

        public Guid BranchId { get; set; }
        public string Branch { get; set; }

    }
}