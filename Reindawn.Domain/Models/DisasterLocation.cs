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
    public class DisasterLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? RespondentId { get; set; } //UserId
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public string Description { get; set; }
        public DisasterLocationStatusEnum Status { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
