
using System.ComponentModel.DataAnnotations;

namespace _200720.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
