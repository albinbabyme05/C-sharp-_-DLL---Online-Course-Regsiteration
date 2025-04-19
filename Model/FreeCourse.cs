using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Registration_System.Model
{
    internal class FreeCourse : CourseLibrary
    {
        public FreeCourse(string title, string instructor) : base(title, instructor)
        {
        }

        public override bool Enroll(User user)
        {
            Console.WriteLine("Please Register to Enroll for the Course !!!");
            return false;
        }
    }
}
