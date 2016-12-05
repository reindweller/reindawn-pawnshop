using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reindawn.Models
{
    public class BranchViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}