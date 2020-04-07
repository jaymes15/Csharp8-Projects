using System;
using System.Collections.Generic;
using System.Text;
using TRAINING.DATABASE.Models;
using static System.Console;
using TRAINING.DATABASE.Data;


namespace TRAINING.INFRASTURE.Controller
{
    public class StudentController: Student
    {
        private readonly TrainningContext _context = new TrainningContext();
       

        public StudentController()
        {
            
        }


        public void Input()
        {
            Student student = new Student();
            WriteLine("enter  your name:");
            string name = ReadLine();
            WriteLine("enter  your age:");
            int age = Convert.ToInt32(ReadLine());
            student.Name = name;
            student.Age = age;
            Register(student);
            
        }
       public void Register(Student student)
        {
            WriteLine(student.Name);
            WriteLine(student.Age);
            _context.Student.Add(student);
            _context.SaveChanges();

        }
        public void GetAllStudent()
        {
            foreach(var student in _context.Student)
            {
                WriteLine($"Name:{student.Name} \n Age:{student.Age}");

            }
           
        }

    }
}
