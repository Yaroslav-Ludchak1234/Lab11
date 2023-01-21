using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab11
{
    internal class Program
    {
        public static void Main()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Asus\\Desktop\\4 course\\Конструювання програмного забезпечення\\11lb\\Lab11\\Lab11\\amit.txt"))
                {
                    sw.WriteLine("Welcome!");
                }
                FileInfo file = new FileInfo("amit.txt");
                // file creation time
                DateTime dt = file.CreationTime;
                Console.WriteLine(dt);
                // last access time
                dt = file.LastAccessTime;
                Console.WriteLine(dt);
                // last write time
                dt = file.LastWriteTime;
                Console.WriteLine(dt);
                Console.ReadLine();
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("C:\\Users\\Asus\\Desktop\\4 course\\Конструювання програмного забезпечення\\11lb\\Lab11\\Lab11\\amit.txt"))
                {
                    sw.WriteLine("Welcome!");
                }
                FileInfo file = new FileInfo("amit.txt");
                // file creation time
                DateTime dt = file.LastWriteTime;            
                Console.WriteLine(dt);
                Console.ReadLine();
            }
        }            
    }
}
