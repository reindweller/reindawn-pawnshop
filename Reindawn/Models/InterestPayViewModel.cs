using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reindawn.Models
{
    public class InterestPayViewModel
    {
        public CustomerViewModel Customer { get; set; }
        public ItemViewModel Item { get; set; }
        public AppraisersSlipViewModel AppraisersSlip { get; set; }
        public SignatureCardViewModel SignatureCard { get; set; }
        public PawnTicketViewModel PawnTicket { get; set; }
    }
}