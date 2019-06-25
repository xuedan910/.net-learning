using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Class_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region create file
            //string path = @"C:\Users\Rain\Desktop\a.txt";
            //File.Create(path);
            #endregion
            #region read file
            //string path = @"C:\Users\Rain\Desktop\a.txt";
            //byte[] buffer = File.ReadAllBytes(path);
            //string file = File.ReadAllText(path);
            //string file = Encoding.Default.GetString(buffer);
            //Console.WriteLine(file);
            #endregion
            #region write file
            //string text = "hello, thank you, thank you very much";
            //File.WriteAllText(@"C:\Users\Rain\Desktop\a.txt", text);
            //byte[] buffer = Encoding.Default.GetBytes(text);
            //File.WriteAllBytes(@"C:\Users\Rain\Desktop\a.txt", buffer);
            #endregion
            
            Console.ReadKey();
        }
    }
}
