using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    class Person
    {
        private string _name;
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void Hello()
        {
            Console.WriteLine("I'm {0}, a human being", this.Name);
        }
    }
}
