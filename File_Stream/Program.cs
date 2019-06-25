using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            #region read small txt file
            //FileStream fs = new FileStream(@"C:\Users\Rain\Desktop\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 2];
            //int res = fs.Read(buffer, 0, buffer.Length);
            //string s = Encoding.Default.GetString(buffer, 0, res);
            //fs.Close();
            //fs.Dispose();

            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion
            #region write txt file
            //using (FileStream fsWrite = new FileStream(@"C:\Users\Rain\Desktop\b.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string s = "Hello World";
            //    byte[] buffer = Encoding.Default.GetBytes(s);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            #endregion
            #region copy a big file
            //using(FileStream fsRead = new FileStream(@"C:\Users\Rain\Desktop\dota.mp4", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 1];

            //    using(FileStream fsWrite=new FileStream(@"C:\Users\Rain\Desktop\dota2.mp4", FileMode.OpenOrCreate, FileAccess.Write))
            //    {
            //        while (true)
            //        {
            //            int r = fsRead.Read(buffer, 0, buffer.Length);
            //            if (r == 0)
            //            {
            //                break;
            //            }
            //            fsWrite.Write(buffer, 0, r);
            //        }
            //    }
            //}
            #endregion
        }
    }
}
