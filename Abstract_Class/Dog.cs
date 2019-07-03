using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Dog:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
