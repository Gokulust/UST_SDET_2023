using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<FamilyMember> Children { get; set; }

        public FamilyMember(string name, int age)
        {
            Name = name;
            Age = age;
            Children = new List<FamilyMember>();
        }

        public void AddChild(FamilyMember child)
        {
            Children.Add(child);
        }

        public void DisplayFamily(int level = 0)
        {
            string indent = new string(' ', 2 * level);
            Console.WriteLine($"{indent}{Name}, Age: {Age}");
            foreach (var child in Children)
            {
                child.DisplayFamily(level + 1);
            }
        }
    }
}
