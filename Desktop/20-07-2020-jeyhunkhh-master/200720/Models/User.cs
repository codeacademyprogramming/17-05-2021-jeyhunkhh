using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _200720.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required] // not null
        [StringLength(50)] // nvarchar(50)
        public string Fullname { get; set; }

        [Required]
        [StringLength(50)]
        public string IdNumber { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
