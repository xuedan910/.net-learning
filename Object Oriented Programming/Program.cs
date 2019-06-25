using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Rain", -32,"male");
            //p.Intro();
            #region use stringbuilder when process massive string operation and Stopwatch to watch the time
            //StringBuilder sb = new StringBuilder();

            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    sb.Append(i);
            //}
            //watch.Stop();
            //Console.WriteLine(watch.Elapsed);
            #endregion
            #region toUpper(),toLower() to uppercase or lowercase the string and Equals() to ignore case sensitive
            //Console.WriteLine("please input your favorite lesson");
            //string strOne = Console.ReadLine();
            //Console.WriteLine("please input your favorite lesson");
            //string strTwo = Console.ReadLine();
            //if (strOne.ToUpper() == strTwo.ToUpper())
            //{
            //    Console.WriteLine("you two like the same lesson");
            //}
            //else
            //{
            //    Console.WriteLine("you two like different lesson");
            //}
            //if (strOne.Equals(strTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("you two like the same lesson");
            //}
            //else
            //{
            //    Console.WriteLine("you two like different lesson");
            //}
            #endregion
            #region split()
            //string s = "a  b _   ,, d";
            //char[] chars = { ' ', ',', '_' };
            //string[] arr = s.Split(chars,StringSplitOptions.RemoveEmptyEntries);
            #endregion
            #region Contains() and Replace()
            //string s = "abcdefg";
            //if (s.Contains("efg"))
            //{
            //    s = s.Replace("efg", "hij");
            //}
            //Console.WriteLine(s);
            #endregion
            //string s = "hello c sharp";
            //string[] arr = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Array.Reverse(arr);
            //Console.WriteLine(string.Join(" ", arr));


            //string email = "abc@gmail.com";
            //string[] arr = email.Split('@');
            //Console.WriteLine("username is {0},domain name is {1}", arr[0], arr[1]);

            //string s = "ajcscdksjnjksbvhjbdvhjsd";
            //int zero = 0;
            //string positions = "";
            //char key = 'j';
            //for (int i = 0; i < s.Length; i++)
            //{
            //    int index = s.IndexOf(key, zero + 1);
            //    if (index < 0)
            //    {
            //        break;
            //    }
            //    else if (index == 0)
            //    {
            //        zero++;
            //    }
            //    else
            //    {
            //        zero = index;
            //    }

            //    if (zero > s.Length)
            //    {
            //        break;
            //    }
            //    positions = positions + ' ' + index;
            //}
            //Console.WriteLine(positions);

            Person p = new Student();
            ((Student)p).Hello();

            Console.ReadKey();
        }
    }
}
