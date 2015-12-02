using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private enum StatusCode
        { SYSTEM_START, SYSTEM_ERROR }

        private static void Main(string[] args)
        {
            StatusCode statusCode = StatusCode.SYSTEM_START;
            switch (statusCode)
            {
                case StatusCode.SYSTEM_START:
                    Console.WriteLine("系統啟動中");
                    break;

                case StatusCode.SYSTEM_ERROR:
                    Console.WriteLine("系統故障");
                    break;

                default:
                    Console.WriteLine("系統啟動中");
                    break;
            }
        }
    }
}