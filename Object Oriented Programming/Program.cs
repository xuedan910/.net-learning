using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Rain";
            p.Age = -32;
            p.Gender = "male";
            p.Intro();
            Console.ReadKey();
        }
    }
}
