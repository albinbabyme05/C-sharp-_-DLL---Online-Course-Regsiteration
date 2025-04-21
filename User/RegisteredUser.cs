using Online_Course_Registration_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Registration_System.User
{
    public class RegisteredUser : User
    {
        private double WalletBalance;
        private Guid UserId { get; set; }
        public RegisteredUser(string name, string email) : base(name, email)
        {
            WalletBalance = 100;
            UserId = Guid.NewGuid();
        }

        public void AddBalance(double amount)
        {
            WalletBalance += amount;
        }

        public double GetBalance()
        {
            return WalletBalance;
        }

        public double GetWalletBalance() => WalletBalance;
        public void SetWalletBalance(double walletbalance) { WalletBalance = walletbalance; }

        public override string RegsiterCourse(CourseLibrary course)
        {
            if (course is FreeCourse)
            {
                return $"You are enrolled for {course.GetTitle()} for free";
            }
            else if (course is PaidCourse pc)
            {
                if(WalletBalance >= pc.GetPrice())
                {
                    WalletBalance -= pc.GetPrice();
                    return $"You are enrolled for {course.GetTitle()} for {pc.GetPrice()}";
                }
                return $"inSuffiecent balance to enroll for {course.GetTitle()}";
            }
            return $" Something went wrong...Try again.";
        }
    }
}
