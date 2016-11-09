using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Domain.Enumerations
{
    public enum PawnTicketTypeEnum
    {
        [Description("Jewellery")]
        DueOnReceipt = 0,

        [Description("Gadget")]
        Days30 = 1
    }
}
