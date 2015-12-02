using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        public string name { get; set; }    //較正式的作法

        // public string name;              //精簡的寫法
        public string email { get; set; }

        public Grade math;

        public void SayHello()
        {
            Console.WriteLine("嗨，你好！ 我是{0}", this.name);
        }

        public void Print()
        {
            string data = "";

            data += string.Format("學生姓名：{0}\n", this.name);
            data += string.Format("學生電郵：{0}\n", this.email);
            if (this.math == null)
                this.math = new Grade() { value = 0 };

            data += string.Format("數學成績：{0}， GPA：{1}\n", this.math.value, this.math.ConvertToGPA());
            Console.WriteLine(data);
        }
    }
}