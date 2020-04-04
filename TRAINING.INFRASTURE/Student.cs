using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.INFRASTURE
{
    public abstract class Student
    {
        protected string Name { get; set; }
      

       protected int Age { get; set; }

        public Student()
        {
            Register();
        }

        protected virtual void Register()
        {
            Write("Enter your Name:");
            this.Name = ReadLine();
            Write("Enter your Age:");
            this.Age = Convert.ToInt32(ReadLine());
           
        }

        
    }
}
