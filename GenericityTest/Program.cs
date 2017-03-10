using GenericityTest.p;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// List常用属性
/// </summary>
namespace GenericityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>(4);

            Person p1 = new Person("xiaoming1", 23);
            Person p2 = new Person("xiaoming2", 24);
            Person p3 = new Person("xiaoming3", 22);
            Person p4 = new Person("xiaoming4", 22);

            Console.WriteLine("##########################添加元素############################");

            //1、添加数据
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            Console.WriteLine("##########################删除元素############################");
            ///2、删除数据
            list.Remove(p2);
            foreach (var p in list)
            {
                Console.WriteLine("输出的人为:" + p.name);
            }

            List<Students> s = new List<Students>();
            Students stu1 = new Students("xiaoming", 24, 189);
            Students stu2 = new Students("xiaohuo", 25, 180);
            Students stu3 = new Students("xiaozhou", 24, 178);

            Console.WriteLine("##########################搜索元素############################");
            s.Add(stu1);
            s.Add(stu2);
            s.Add(stu3);
            //3、搜索
            int index = s.IndexOf(stu2);

            Console.WriteLine("index======>{0}:", index);

            Console.WriteLine("##########################访问元素############################");
            ////4、访问每个元素
            for (int i = 0; i < s.Count; i++)
            {
                Console.WriteLine(s[i].name);
            }

            Console.WriteLine("###########################插入元素###########################");
            ////插入元素
            List<MyClass> listClass = new List<MyClass>(new MyClass[] { new MyClass(1, "jianzi"), new MyClass(2, "niubi") });
            listClass.Insert(1,new MyClass(3,"3班"));

           // s.Insert(1, new Students("nihao",30, 188));

            foreach (var cla in listClass)
            {
                Console.WriteLine(cla.name);
            }

            Console.WriteLine("########################排序元素###############################");
            //listClass.Sort();

            foreach (var item in listClass)
            {
                Console.WriteLine(item.classNum);
            }
            ////倒序
            listClass.Reverse();
            foreach (var item in listClass)
            {
                Console.WriteLine(item.classNum);
            }

            Console.WriteLine("########################只读###############################");

            ReadOnlyCollection<Students> studend = s.AsReadOnly();
            Console.WriteLine("输出只读。。。。");
            foreach (var item in s)
            {
                Console.WriteLine(item.age);
            }
            Console.ReadLine();


        }
    }

}
