using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class American : Person
    {
        public American(string name) : base(name) { }

        public override void Hello()
        {
            Console.WriteLine("I'm {0}, I come from USA", this.Name);
        }
    }
}
