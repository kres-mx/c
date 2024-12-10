using System.Collections.Generic;

namespace University.Data_Model
{
    public class lecStudent : Student
    {
        public List<string> PracticedCourses { get; set; }

        public lecStudent(string id, string name, int age, string phoneNumber, string email, string track, string specialization, int totalGrade, int currentGrade, List<string> practicedCourses)
            : base(id, name, phoneNumber, email, track, specialization, totalGrade, currentGrade)
        {
            PracticedCourses = practicedCourses;
        }
    }
}
