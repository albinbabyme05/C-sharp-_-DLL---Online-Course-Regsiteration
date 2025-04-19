using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Registration_System.Model
{
    public class CourseLibrary
    {
        private Guid CourseId;
        private string Title;
        private string Instructor;
        public string Duration;
        public bool IsAvailable;

        public CourseLibrary(string title, string instructor)
        {
            Title = title;
            Instructor = instructor;
            CourseId = Guid.NewGuid();
        }

        public void GetCourseInfo()
        {
            Console.WriteLine($"Course: {Title} - Id: {CourseId} - Teacher: {Instructor} -Duration:{Duration}");
        }

        public String GetTitle() => Title;
        public string GetInstructor() => Instructor;
        public Guid GetCourseId() => CourseId;
      
    }
}
