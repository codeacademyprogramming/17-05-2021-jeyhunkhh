using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _210720.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        public int GroupId { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        public Group Group { get; set; }


        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
