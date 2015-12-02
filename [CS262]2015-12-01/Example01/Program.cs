using EasyMathLibrary;
using StudentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  string name = "Resnick";
            //  string email = "resnick1223@gnail.com";
            //  Console.WriteLine("Hello World,{0}", name);

            Student aStudent = new Student()
            {
                name = "Resnick",
                email = "resnick1223@gamil.com",
                math = new Grade() { value = 100 }
            };  //代表一個程式
            aStudent.Print();
            aStudent.SayHello();

            Line line = new Line();
            line.startPoint = new Point() { x = 1, y = 1 };
            line.endPoint = new Point() { x = 3, y = 4 };       //x=1 正無限大
            Console.WriteLine("X = {0}, Y = {1}", 4, line.GetY(4));
        }
    }
}