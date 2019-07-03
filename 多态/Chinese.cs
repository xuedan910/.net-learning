using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Chinese : Person
    {
        public Chinese(string name) : base(name) { }

        public override void Hello()
        {
            Console.WriteLine("I'm {0}, I come from China", this.Name);
        }
    }
}
