using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialize_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Rain";
            p.Age = 32;

            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream fsWrite=new FileStream(@"C:\Users\Rain\Desktop\a.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                bf.Serialize(fsWrite, p);
            }
        }
    }

    [Serializable]
    class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
        
        private int _age;
        public int Age
        {
            get { return _age; }
            set { this._age = value; }
        }
    }
}
