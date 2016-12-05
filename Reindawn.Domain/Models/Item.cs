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
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public ItemTypeEnum ItemTypeEnum { get; set; }
        //jewelry
        public decimal Weight { get; set; }
        public JewelryTypeEnum JewelryType { get; set; }

        //gadget
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNo { get; set; }
        public string Name { get; set; }

        public Guid BranchId { get; set; }
        public virtual Branch Branch { get; set; }

    }
}
