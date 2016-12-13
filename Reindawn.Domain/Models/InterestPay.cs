using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Domain.Models
{

    public class InterestPay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public Guid AppraisersSlipId { get; set; }
        public virtual AppraisersSlip AppraisersSlip { get; set; }

        public Guid SignatureCardId { get; set; }
        public virtual SignatureCard SignatureCard { get; set; }

        public Guid PawnTicketId { get; set; }
        public virtual PawnTicket PawnTicket { get; set; }

        public DateTime DatePosted { get; set; }
    }
}
