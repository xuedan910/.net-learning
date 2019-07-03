using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese ch1 = new Chinese("Li Lei");
            Chinese ch2 = new Chinese("Han Meimei");
            American a1 = new American("Rain");
            American a2 = new American("Emma");
            Person[] persons = new Person[] { ch1, ch2, a1, a2 };

            foreach (var item in persons)
            {
                item.Hello();
            }

            Console.ReadKey();
        }
    }
}
