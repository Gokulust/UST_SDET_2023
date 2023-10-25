using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class NonGeneric
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(3);
            arrayList.Add(4);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push("gokul");
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
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public void HashTableHandling()
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, 10);
            hashTable.Add(2, 20);
            hashTable.Add(3, 30);

            foreach(var item in hashTable)
            {
                Console.WriteLine(item);
            }
        }
           
    }
}
