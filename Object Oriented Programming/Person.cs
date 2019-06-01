using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value < 0 || value > 100 ? 0 : value;
            }
        }
        private string _gender;
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void Intro()
        {
            Console.WriteLine("Hello, I'm {0}, I'm {1} years old. And I'm a {2}", Name, Age, Gender);
        }
    }
}
