using System;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class EventModel
    {
        public int Id { get; set; }

        [Required, MinLength(3)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required, MinLength(3)]
        public string Location { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
