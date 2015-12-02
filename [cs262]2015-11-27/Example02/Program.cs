using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("InPut:{0}", number);

            Console.WriteLine("請輸入一個數字：");
            double number01 = 0.0;
            bool 轉成功沒 = double.TryParse(Console.ReadLine(), out number01);
            Console.WriteLine(轉成功沒);
            if (轉成功沒)
                Console.WriteLine("It is :{0}", number01);
        }
    }
}