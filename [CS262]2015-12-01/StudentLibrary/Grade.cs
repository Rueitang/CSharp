using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Grade
    {
        public float value;

        public int ConvertToGPA()
        {
            int gpa;
            if (this.value < 50)
            {
                gpa = 1;
            }
            else if (this.value >= 50 && this.value < 60)
            {
                gpa = 2;
            }
            else if (this.value >= 60 && this.value < 70)
            {
                gpa = 3;
            }
            else if (this.value >= 70 && this.value < 80)
            {
                gpa = 4;
            }
            else if (this.value >= 80 && this.value < 90)
            {
                gpa = 5;
            }
            else
            {
                gpa = 6;
            }
            return gpa;
        }
    }
}