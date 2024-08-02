using System.ComponentModel.DataAnnotations;

namespace CipherTest.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Class { get; set; }

        public List<SubjectLanguage> SubjectLanguages { get; set; } = new List<SubjectLanguage>();
        public List<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();
        public List<TeacherSubject> TeacherSubjects { get; set; } = new List<TeacherSubject>();
    }

    public class SubjectLanguage
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        [Required]
        public string Language { get; set; }
    }
}
