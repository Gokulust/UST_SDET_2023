using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class ArrayEx
    {
         readonly int[] numbers = new int[5];

        public void OneDim()
        {
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            for(int i=0;i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        int[,] nums=new int[2,2];
        int[,] test = { { 1, 2, 3 }, { 2, 3, 4 } };
        public void TwoDim()
        {
            nums[0,0] = 100;
            nums[0,1] = 200;
            nums[1,0] = 300;
            nums[1,1] = 400;
            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }

        }
        public void jaggered()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] { { 1, 2, } },
                new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 3, 5, 6 } }
            };
            foreach (var item in arr)
            {
                Console.WriteLine("***");
                foreach (var number in item)
                {
                    Console.WriteLine(number);
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int x = 0
;
                for (int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for (int k = 0; k < arr[j].Rank; k++)
                    {
                        Console.Write(arr[i][j, k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
        
    }
}
