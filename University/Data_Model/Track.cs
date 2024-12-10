using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Data_Model
{
    public class Track
    {
        public string TrackName { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }

        // Constructor
        public Track(string trackName)
        {
            TrackName = trackName;
            Courses = new List<Course>();
            Students = new List<Student>();
        }
    }

}
