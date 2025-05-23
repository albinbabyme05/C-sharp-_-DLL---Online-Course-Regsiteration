﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Course_Registration_System.Model
{
    public class PaidCourse : CourseLibrary
    {
        private double Price;

        public PaidCourse(string title, string instructor, string duration, double price) : base(title, instructor, duration)

   
        {
            Price = price; 
        }

        public double GetPrice() => Price;
        public void SetPrice(double price) { Price = price; }
    }
}
