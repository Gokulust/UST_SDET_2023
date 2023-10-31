using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class DelegateExample
    {
        //public DelegateExample(int num1, int num2)
        //{
        //    this.num1 = num1;
        //    this.num2 = num2;
        //}

        public int num1 {  get; set; }
        public int num2 { get; set; }
        public  void MethodA()
        {
            Console.WriteLine("Hello");

        }
        public void Add(int num1,int num2)
        {
            Console.WriteLine(num1+num2);
        }
        public void Sub(int num1,int num2)
        {
            Console.WriteLine(num1-num2);
        }
    }
}
