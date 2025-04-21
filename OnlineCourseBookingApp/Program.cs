
using System.Collections.Generic;
using Online_Course_Registration_System.Model;
using Online_Course_Registration_System.Service;
using Online_Course_Registration_System.User;



class Program
{
    static void Main(string[] args)
    {
        CourseManager manager = new CourseManager();

        PaidCourse paidCourse1 = new PaidCourse("xyz", "albin", "90 Min.",49.99);
        FreeCourse freeCourse2 = new FreeCourse("abc", "unni",  "120 Min.");

        manager.AddCourse(paidCourse1);
        manager.AddCourse(freeCourse2);

        // write all course
        foreach (var item in manager.GetFreeCourses())
        {
            Console.WriteLine($"Name: {item.GetTitle()} - Instructor: {item.GetInstructor()} - {item.GetCourseId()} ");
            Console.WriteLine("==============================");
        }
        foreach (var item in manager.GetPaidCourses())
        {
            Console.WriteLine($"Name: {item.GetTitle()} - Instructor: {item.GetInstructor()} - {item.GetCourseId()} ");
            Console.WriteLine("==============================");
        }

        Console.WriteLine("==============================");

        RegisteredUser reg_user1 = new RegisteredUser("albin", "albin@gmail.com");

        reg_user1.SetWalletBalance(60);
        Console.WriteLine(reg_user1.RegsiterCourse(paidCourse1));
        Console.WriteLine($"Current balance = "+reg_user1.GetWalletBalance());

        Console.WriteLine("================= All Course ======================");
        foreach (var item in manager.DisplayAllCourse())
        {
            Console.WriteLine($"courseName: {item.GetTitle()} - Id: {item.GetCourseId()} " +
                $"- Duration: {item.Duration} - Instructor: {item.GetInstructor()}  ");
        }


    }
}
