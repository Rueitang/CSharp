using ClassLibrary1;
using ExampleLibrary;
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
            Student student = new Student();

            student.name = "口";
            student.phone = "123";

            Class1 class001 = new Class1();
            class001.id = "23232";
        }
    }
}