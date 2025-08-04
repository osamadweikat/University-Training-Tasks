using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrandsShops.Api.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Range(16, 30, ErrorMessage = "Age must be between 16 and 30.")]
        public int Age { get; set; }

        [Column(TypeName = "datetime(6)")]
        public DateTime EnrollmentDate { get; set; }

        [Range(0.0, 4.0, ErrorMessage = "Grade must be between 0.0 and 4.0.")]
        public decimal? Grade { get; set; }
    }
}
