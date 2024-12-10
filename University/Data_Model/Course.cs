using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data_Model
{
    public class Course
    {
        public string Name { get; set; }
        public string CourseID { get; set; }
        public List<Student> Students { get; } = new List<Student>();
        public List<Lecturer> Lecturers { get; } = new List<Lecturer>();


        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
                student.EnrollInCourse(this);
            }
        }

        public void AddLecturer(Lecturer lecturer)
        {
            Lecturers.Add(lecturer);
        }


    }
}
