using StudentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //     int[] grades = new int[10];

            //   int length = 10;
            // int[] grades2 = new int[length];

            //  int length2 = int.Parse(Console.ReadLine());
            //  int[] grades3 = new int[length2];

            //            int[] grades4 = new int[] { 3, 2, 1 };

            //          int[] grades5 = { 4, 5, 6 };

            //        int[] grades6;
            //      grades6 = new int[] { 5, 6, 7, 8 };

            //    int[,] table = new int[,]
            //  {
            //    {1,2,4 },
            //   {3,4,5 }
            //  };

            //   int[][] table2 = new int { { 1, 2 }, { 4, 5 } };
            Student[] students = new Student[3];
            students[0] = new Student() { name = "A" };
            students[1] = new Student() { name = "B" };
            students[2] = new Student() { name = "C" };
            //            Student[] students2 = new Student [3]
            string[] names = { "A", "B", "C" };
            for (int number = 0; number < students.Length; number++)
            {
                students[number] = new Student { name = names[number] };
                students[number].SayHello();
                students[number].Print();
            }
            foreach (Student student in students)
            {
                student.SayHello();
                student.Print();
            }
        }
    }
}