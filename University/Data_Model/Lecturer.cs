using System.Collections.Generic;

namespace University.Data_Model
{
    public class Lecturer : User
    {
        public string Track { get; set; }
        public string Specialization { get; set; }
        public int TotalGrade { get; set; }
        public int CurrentGrade { get; set; }
        public List<Course> Courses { get; } = new List<Course>();

        public Lecturer(string id, string name, string phoneNumber, string email, string track, string specialization, int totalGrade, int currentGrade)
            : base(id, name, phoneNumber, email)
        {
            Track = track;
            Specialization = specialization;
            TotalGrade = totalGrade;
            CurrentGrade = currentGrade;
        }

        public void AssignToCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                course.AddLecturer(this);
            }
        }
    }
}
