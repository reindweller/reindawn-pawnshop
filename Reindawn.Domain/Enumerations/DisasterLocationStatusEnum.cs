using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Domain.Enumerations
{

    public enum DisasterLocationStatusEnum
    {
        [Description("Unresponded")]
        Unresponded = 0,

        [Description("Responding")]
        Responding = 1,

        [Description("Responded")]
        Responded = 2,

        [Description("Cancelled")]
        Cancelled = 3
    }
}
