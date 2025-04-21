using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Registration_System.Model
{
    public class FreeCourse : CourseLibrary
    {
        public FreeCourse(string title, string instructor, string duration) : base(title, instructor, duration)
        {
        }

        
    }
}
