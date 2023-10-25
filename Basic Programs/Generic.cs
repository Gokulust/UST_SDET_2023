using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Generic
    {
        public void ArrayListHandling()
        {
            List<int> list = new List<int>();

            list.Add(2);
            list.Add(1);
            list.Add(5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
        public void StackHandling()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
        }
        public void QueueHandling()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public void DictionaryHandling()
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "vishnu");
            dictionary.Add(2, "shirin");
            dictionary.Add(3, "jachithra");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
