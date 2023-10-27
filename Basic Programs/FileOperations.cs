using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class FileOperations
    {
       public void CreateFile()
        {
            FileInfo file = new FileInfo("C:\\Users\\Administrator\\Desktop\\FileOperations\\Sample.txt");
            using StreamWriter str=file.CreateText();
            Console.WriteLine("File has Benn created");
            str.WriteLine("hello shirin");
            str.WriteLine("hi vishnu");
            Console.WriteLine("Written");

        }
    }
}
