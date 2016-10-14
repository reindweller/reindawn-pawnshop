using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reindawn.Domain.Enumerations;

namespace ReindawnApi.Models
{
    public class DisasterLocationViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid? RespondentId { get; set; } //UserId
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public string Description { get; set; }
        public DisasterLocationStatusEnum Status { get; set; }
        public DateTime DatePosted { get; set; }
    }

    public class DisasterLocationUpdateViewModel
    {
        public Guid Id { get; set; }
        public Guid RespondentId { get; set; } //UserId
    }
}