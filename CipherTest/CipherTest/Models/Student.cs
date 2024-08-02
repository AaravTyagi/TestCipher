using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CipherTest.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int Age { get; set; }

        public string? ImagePath { get; set; }

        [StringLength(50, ErrorMessage = "Class cannot be longer than 50 characters.")]
        public string Class { get; set; }

        [Required(ErrorMessage = "Roll number is required.")]
        public int RollNumber { get; set; }

        public List<StudentSubject> StudentSubjects { get; set; }= new List<StudentSubject>();
    }

    public class StudentSubject
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
