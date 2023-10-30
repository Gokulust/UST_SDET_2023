using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class GenericExample<T>
    {
        private T valueOne, ValueTwo;
        private T[] arr;
        public GenericExample(T valeOne,T valueTwo)
        {
            this.ValueOne = valeOne;
            this.ValueTwo1 = valueTwo;
            
        }
        public GenericExample(T[] arr)
        {
            this.arr= arr;
        }

        public T ValueOne { get => valueOne; set => valueOne = value; }
        public T ValueTwo1 { get => ValueTwo; set => ValueTwo = value; }

        public void Display()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
