using System;

namespace Domain.RawModels
{
    public class RawReview
    {
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
    }
}