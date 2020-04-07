using System;
using System.Collections.Generic;
using System.Text;
using TRAINING.INFRASTURE;
using static System.Console;


namespace TRAINING.INFRASTURE.Controller
{
    public class UndergraduateController 
    {
        public const int rowNumber = 4;
        public const int colNumber = 2;
        public string[,] yearOneCourses = new string[rowNumber, colNumber]{
                                                   { "Introductory Biology", "2 units" },
                                                   { "Introductory Physics", "2 units" } ,
                                                   {"Introductory Chemistry", "2 units" },
                                                   {"Introductory Mathematics", "2 units" }
                                             };
       

        protected string[,] courses = new string[rowNumber, colNumber];

        string enteredDepartment;
    }
}
