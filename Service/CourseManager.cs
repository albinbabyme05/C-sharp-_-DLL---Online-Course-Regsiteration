using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Course_Registration_System.Model;

namespace Online_Course_Registration_System.Service
{
    public class CourseManager
    {
        private List<CourseLibrary> courseList = new List<CourseLibrary>();

        public void AddCourse(CourseLibrary course)
        {
            courseList.Add(course);
        }

        public List<PaidCourse> GetPaidCourses()
        {
            List<PaidCourse> paidCourseList = new List<PaidCourse>();
            foreach (var course in courseList)
            {
                if (course is PaidCourse pc)
                {
                    paidCourseList.Add(pc);
                }
            }
            return paidCourseList;
        }

        public List<FreeCourse> GetFreeCourses()
        {
            List<FreeCourse> freeCourseList = new List<FreeCourse>();
            foreach (var course in courseList)
            {
                if (course is FreeCourse pc)
                {
                    freeCourseList.Add(pc);
                }
            }
            return freeCourseList;
        }
    }
}
