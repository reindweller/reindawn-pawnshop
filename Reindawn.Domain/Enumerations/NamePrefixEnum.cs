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
        Mr = 0,

        [Description("Mrs.")]
        Mrs = 1,

        [Description("Miss")]
        Miss = 2
    }
}
