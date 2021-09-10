using System;
using System.ComponentModel.DataAnnotations;

namespace ConferencePlanner.GraphQL.Data
{
    public class Session
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Title { get; set; }

        [StringLength(4000)]
        public string? Abstract { get; set; }

        public DateTimeOffset? StartTime { get; set; }

        public DateTimeOffset? EndTime { get; set; }

        public int TrackId { get; set; }

        public Track Track { get; set; } = default!;

    }
}