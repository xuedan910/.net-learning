using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("name", "Rain");
            table.Add("age", 32);
            foreach (var item in table.Keys)
            {
                Console.WriteLine(table[item]);
            }
        
            Console.ReadKey();
        }
    }
}
