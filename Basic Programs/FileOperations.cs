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
       public void WriteData()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\FileOperations\\Sample2.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamWriter=new StreamWriter(fileStream);
            Console.WriteLine("Enter the text whic you want to write to the file");
            string str = Console.ReadLine();
            streamWriter.WriteLine(str);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\FileOperations\\Sample.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str=sr.ReadToEnd();
            Console.WriteLine(str);
            sr.Close();
            fs.Close();
        }
        public void CopyMoveFile()
        {
            FileInfo fil = new FileInfo("C:\\Users\\Administrator\\Desktop\\FileOperations\\Sample.txt");
            FileInfo file2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\FileOperations\\Sample2.txt");
            fil.CopyTo("C:\\Users\\Administrator\\Desktop\\FileOperations\\Temp\\sampletemp1.txt");
            file2.MoveTo("C:\\Users\\Administrator\\Desktop\\FileOperations\\Temp\\Sample2.txt");
            

        }
        public void DeleteFile()
        {
            FileInfo file = new FileInfo("C:\\Users\\Administrator\\Desktop\\FileOperations\\Temp\\sampletemp1.txt");
            file.Delete();
        }
    }
}
