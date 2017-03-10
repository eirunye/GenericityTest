using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericityTest.p
{
    class Students
    {
        public string name;
        public int age;
        public int high;

        public Students(string name,int age,int high)
        {
            this.name = name;
            this.age = age;
            this.high = high;
        }

        public void Aat()
        {
            Console.WriteLine("学生在吃饭!");
        }
    }
}
