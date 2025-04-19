using Online_Course_Registration_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Registration_System.User
{
    public class GuestUser : User
    {
        public GuestUser(string name, string email) : base(name, email)
        {
        }

        public override string RegsiterCourse(CourseLibrary course)
        {
            if (course is FreeCourse)
            {
                return $"you are enrolled for {course.GetTitle()}";
            }
            else
            {
                return $"you are not enrolled for {course.GetTitle()}";
            }
        }
    }
}
