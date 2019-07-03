using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_practice
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Bird : IFlyable
    {
        /// <summary>
        /// It's the Bird class's own method
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("I can fly");
        }

        /// <summary>
        /// implement interface method
        /// </summary>
        void IFlyable.Fly()
        {
            Console.WriteLine("I'm the interface fly");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
