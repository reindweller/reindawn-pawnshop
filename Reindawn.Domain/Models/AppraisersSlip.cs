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
    public class AppraisersSlip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid SignatureCardId { get; set; }
        public virtual SignatureCard SignatureCard { get; set; }
        public DateTime Date { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Amount { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Quantity { get; set; }
        public JewelryTypeEnum? JewelryType { get; set; }
        public decimal? Carat { get; set; }
        public string Remarks { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Inclusions { get; set; }
        public string SerialNo { get; set; }

    }
}
