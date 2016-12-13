using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reindawn.Domain.Enumerations;
using Reindawn.Domain.Models;

namespace Reindawn.Models
{
    public class ItemViewModel
    {
        public Guid Id { get; set; }
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
        public List<SelectListItem> BranchSelectListItems { get; set; }

        public string Details { get; set; }
    }
}