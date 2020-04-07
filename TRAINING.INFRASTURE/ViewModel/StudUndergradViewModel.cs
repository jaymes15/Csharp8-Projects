using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTURE.ViewModel
{
    class StudUndergradViewModel
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public int Level { get; set; }
        public string department { get; set; }
       
        public string[] departments = new string[] { "Biology", "Physics", "Mathematics", "Chemistry" };

        protected string[,] courses;

    }
}
