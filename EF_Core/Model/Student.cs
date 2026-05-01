using System.ComponentModel.DataAnnotations;

namespace EF_Core.Model
{
    public class Student
    {
        public int Id { get; set; } // Primary key
        public required string Name { get; set; }

        [EmailAddress]
        public required string Email { get; set;  }
    }
}
