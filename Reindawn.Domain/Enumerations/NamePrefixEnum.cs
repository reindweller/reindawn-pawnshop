using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reindawn.Domain.Enumerations
{
    public enum NamePrefixEnum
    {
        [Description("Mr.")]
        DueOnReceipt = 0,

        [Description("Mrs.")]
        Days30 = 1,

        [Description("Miss")]
        Days60 = 2
    }
}
