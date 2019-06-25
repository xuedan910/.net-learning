using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            ////list.Clear();
            ////list.RemoveAt(0);
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(0, "hello");
            //dic.Add(1, "world");
            //foreach (KeyValuePair<int,string> item in dic)
            //{
            //    Console.WriteLine("{0}----{1}", item.Key, item.Value);
            //}
            #region Practice one
            //separate odd and even from a list of numbers, and put them into different lists. even numbers on left, odds on right
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    odd.Add(nums[i]);
                }
                else
                {
                    even.Add(nums[i]);
                }
            }
            even.AddRange(odd);
            #endregion
            #region Practice two
            //separate user's input into char array
            //Console.WriteLine("please input anything you want");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    chs[i] = input[i];
            //}
            #endregion
            #region Practice three
            //count the frequency of each character's occurance in "Welcome to China" *case insensitive
            string str = "Welcome to China";
            str = str.ToLower();
            Dictionary<char, int> result = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == ' ')
                {
                    continue;
                }
                if (result.ContainsKey(ch))
                {
                    result[ch]++;
                    continue;
                }
                result.Add(ch, 1);
            }

            foreach (KeyValuePair<char, int> item in result)
            {
                Console.WriteLine("{0}---{1}", item.Key, item.Value);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
