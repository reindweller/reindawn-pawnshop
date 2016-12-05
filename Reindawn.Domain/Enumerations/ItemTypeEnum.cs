using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Domain.Enumerations
{
    public enum ItemTypeEnum
    {
        [Description("Jewellery")]
        Jewellery = 0,

        [Description("Gadget")]
        Gadget = 1
    }
}
