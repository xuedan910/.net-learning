using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MD5_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";
            Console.WriteLine(GetMD5(str));
            Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] byteBuffer = Encoding.Default.GetBytes(str);
            byte[] md5Buffer = md5.ComputeHash(byteBuffer);

            string res = "";
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                res += md5Buffer[i].ToString();
            }

            return res;
        }
    }
}
