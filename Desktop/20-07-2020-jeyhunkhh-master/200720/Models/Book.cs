using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _200720.Models
{
    public enum Status
    {
        Pending,
        InUse,
        Canceled,
        Ended
    }

    public class Book
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public Room Room { get; set; }
        public User User { get; set; }
    }
}
