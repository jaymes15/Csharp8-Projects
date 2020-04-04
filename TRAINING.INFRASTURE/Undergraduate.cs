using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.INFRASTURE
{
    public class Undergraduate : Student
    {
        protected int Level { get; set; }
        protected string department { get; set; }
        //int numberOfDepartments = 5;
        protected string[] departments = new string[]{"Biology", "Physics", "Mathematics", "Chemistry" };
        protected const int rowNumber = 4;
        protected const int colNumber= 2;
        private string[,] yearOneCourses =  new string [rowNumber, colNumber]{ 
                                                   { "Introductory Biology", "2 units" },
                                                   { "Introductory Physics", "2 units" } ,
                                                   {"Introductory Chemistry", "2 units" },
                                                   {"Introductory Mathematics", "2 units" }
                                             };
        protected string[,] courses = new string[rowNumber, colNumber];
       

        string enteredDepartment;

        #region Constructor
        protected override void Register()
        {
            base.Register();
            this.Level = 1;
            displayDepartments();
          
        }
        #endregion

        #region Display Registration information
        protected void displayRegInfo()
        {
            WriteLine($"=====================================================================");
            WriteLine($"Registration Successful");
            WriteLine($"=====================================================================");
            WriteLine();
            WriteLine($"{this.Name} Registration Information");
            WriteLine();
            WriteLine($"Name: {this.Name}");
            WriteLine($"Department: {this.department}");
            WriteLine($"Level: {this.Level}");
            WriteLine($"Age: {this.Age}");
            WriteLine($"=====================================================================");
            WriteLine($"REGISTERED COURSES");
            WriteLine($"=====================================================================");
            showRegisteredCourses();



        }

        #endregion

        #region Display Departments
        protected void displayDepartments()
        {
            WriteLine("Enter your Department From the avliable departments:");
            foreach (var department in departments)
            {
                WriteLine($"* {department} ");
            }
            enteredDepartment = ReadLine();
            checkDepartmentSelected(enteredDepartment);
        }
        #endregion

        #region Check Department Selected
        private void checkDepartmentSelected(string enteredDepartment)
        {
            switch (enteredDepartment.ToLower())
            {
                case "biology":
                    this.department = enteredDepartment;
                    yearOneStudentCourseReg();
                    displayRegInfo();
                    break;
                case "physics":
                    this.department = enteredDepartment;
                    yearOneStudentCourseReg();
                    displayRegInfo();
                    break;
                case "chemistry":
                    this.department = enteredDepartment;
                    yearOneStudentCourseReg();
                    displayRegInfo();
                    break;
                case "mathematics":
                    this.department = enteredDepartment;
                    yearOneStudentCourseReg();
                    displayRegInfo();
                    break;
                default:
                    WriteLine("Invalid Selection,Please make a valid selection");
                    displayDepartments();
                    break;

            }
        }
        #endregion


        #region Year One Student Course Registration
        protected virtual void yearOneStudentCourseReg()
        {
            for (int rowIndexing = 0; rowIndexing < rowNumber; rowIndexing++)
            {
                for (int colIndexing = 0; colIndexing < colNumber; colIndexing++)
                {
                    courses[rowIndexing, colIndexing] =yearOneCourses[rowIndexing, colIndexing];
                }
                
            }
        }
        #endregion

        #region Show Registered Courses
        private void showRegisteredCourses()
        {
            for (int rowIndexing = 0; rowIndexing < rowNumber; rowIndexing++)
            {
                for (int colIndexing = 0; colIndexing < colNumber; colIndexing++)
                {
                    Write($"{courses[rowIndexing, colIndexing],-30}");
                }
                WriteLine();
            }
        }
        #endregion
    }
}
