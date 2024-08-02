using System.ComponentModel.DataAnnotations;

namespace CipherTest.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Sex { get; set; }

        
        public string? ImagePath { get; set; }

        public List<TeacherSubject> TeacherSubjects { get; set; }=new List<TeacherSubject>();
    }

    public class TeacherSubject
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
