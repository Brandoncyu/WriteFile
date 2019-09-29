using System;
using System.IO;

namespace WriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\v-brayu\Desktop\MyTestFile.txt";
            FileInfo fl = new FileInfo(path);
            string path2 = @"C:\Users\v-brayu\Desktop\MyTestFile2.txt";
            FileInfo fl2 = new FileInfo(path2);
            string path3 = @"C:\Users\v-brayu\Desktop\MyTestFile3.txt";
            FileInfo fl3 = new FileInfo(path3);
            /*
            fl.Delete();
            Console.WriteLine("File has been deleted");
            */
            StreamWriter str = fl.CreateText();
            str.WriteLine("hello");
            Console.WriteLine("File has been created with text");
            str.Close();
            fl.CopyTo(path2);
            Console.WriteLine("{0} was copied to {1}.", path, path2);
            fl.MoveTo(path3);
            Console.WriteLine("{0} was moved to {1}.", path, path3);
            
            StreamWriter sw = fl3.AppendText();
            sw.WriteLine("World!");
            sw.Close();
            
            StreamReader sr = fl3.OpenText();
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
