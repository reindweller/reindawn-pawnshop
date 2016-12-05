using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Domain.Enumerations
{
    //TODO: add more jewelry type
    public enum JewelryTypeEnum
    {
        [Description("Necklace")]
        Necklace = 0,

        [Description("Ring")]
        Ring = 1,

        [Description("Earring")]
        Earring = 2
    }
}
