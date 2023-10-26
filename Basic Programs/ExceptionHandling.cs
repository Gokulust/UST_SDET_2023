using Basic_Programs.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ExceptionHandling
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public void Divide()
        {
            try
            {
                int[] num = {10,20,30};
                int result = NumberOne / NumberTwo;
                Console.WriteLine(result);
                foreach (int i in num)
                {
                    Console.WriteLine(i);
                }
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(MyException.exMessagesList[1]);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
        public void NumCheck()
        {
            if(NumberOne>100)
            {
                Console.WriteLine("okey");
            }
            else
            {
                throw new NumberOneException(MyException.exMessagesList[4]);
            }
        }
    }
}
