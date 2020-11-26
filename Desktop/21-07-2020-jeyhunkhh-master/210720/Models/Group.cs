using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _210720.Models
{
    public class Group
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
