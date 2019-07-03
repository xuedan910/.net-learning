using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public enum Gender
    {
        male,
        female
    }
    public struct Person
    {
        public string name;
        public int age;
        public Gender gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region enum and struct
            //Person p1;
            //p1.name = "rain";
            //p1.age = 32;
            //p1.gender = Gender.male;
            //Console.WriteLine(p1.gender);
            #endregion
            #region array practice one
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //int min = nums[0];
            //int max = nums[0];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}

            //Console.WriteLine("The max value is {0}", max);
            //Console.WriteLine("The min value is {0}", min);
            //Console.WriteLine("total is {0}", sum);
            //Console.WriteLine("average is {0}", sum/(nums.Length * 1.0));
            #endregion
            #region array practice two
            //string[] names = { "Jack", "Rico", "Rain" };
            //string str = "";
            //for (int i = 0; i < names.Length - 1; i++)
            //{
            //    str = str + names[i] + '|';
            //}
            //Console.WriteLine(str + names[names.Length - 1]);
            #endregion
            #region 冒泡排序
            //int[] nums = { 5, 7, 3, 1, 6, 0, 8, 9, 4, 2 };

            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums.Length - 1 - i; j++)
            //    {
            //        if (nums[j] > nums[j+1])
            //        {
            //            int tmp = nums[j];
            //            nums[j] = nums[j+1];
            //            nums[j+1] = tmp;
            //        }
            //    }
            //}
            //Console.WriteLine(nums);
            #endregion
            #region can only input Y or N
            //Console.WriteLine("\nplease input \"Y\" or \"N\"");
            //string input = Console.ReadLine();
            //Program.YesNo(input);
            #endregion
            #region out param in function
            //int[] nums = { 1, 2, 3, 4, 5 };
            //int min, max, sum;
            //double avg;
            //Program.ArrayCal(nums, out min, out max, out sum, out avg);
            //Console.WriteLine("The min is {0}, the max is {1}, the total is {2}, the avg is {3}", min, max, sum, avg);
            //Console.ReadKey();
            #endregion
            #region params in function
            //string name = "Jack";
            //int[] scores = { 1, 2, 3, 4, 5 };
            //Program.ScoreCal(name, 1, 2, 3, 4, 5);
            #endregion
            Console.WriteLine("please input the first number:");
            string strNumOne = Console.ReadLine();
            int numOne = GetNum(strNumOne);

            Console.WriteLine("please input the second number:");
            string strNumTwo = Console.ReadLine();
            int numTwo = GetNum(strNumTwo);

            compareNums(numOne,ref numTwo);
            int sum = GetSum(numOne, numTwo);
            Console.WriteLine("the total number is {0}", sum);
            Console.ReadKey();
        }

        public static int GetSum(int num1, int num2)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                sum += i;
            }

            return sum;
        }
        public static void compareNums(int num1,ref int num2)
        {
            while (true)
            {
                if (num1 < num2)
                {
                    return;
                }
                Console.WriteLine("the second number has to be bigger. please try again!");
                string strNum = Console.ReadLine();
                num2 = Program.GetNum(strNum);
            }
        }
        public static int GetNum(string str)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(str);
                    return num;
                }
                catch
                {
                    Console.WriteLine("Input has to be numeric. please try again!");
                    str = Console.ReadLine();
                }
            }
        }
        public static void ArrayCal(int[] nums, out int min, out int max, out int sum, out double avg)
        {
            min = nums[0];
            max = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
                if (max < nums[i])
                {
                    max = nums[i];
                }
                sum += nums[i];
            }
            avg = sum * 1.0 / nums.Length;
        }
        public static void YesNo(string input)
        {
            while (true)
            {
                if (input == "y" || input == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nplease input \"Y\" or \"N\"");
                    input = Console.ReadLine();
                }
            }
        }
        public static void ScoreCal(string name, params int[] scores)
        {
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            Console.WriteLine("The score of {0} is {1}", name, sum);
            Console.ReadKey();
        }
    }
}
