using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyException
    {
        public static Dictionary<int,string> exMessagesList = new Dictionary<int, string>()
        {
            {1, "Dont give 0 for denominator" },
            {2, "Index is Out of range" },
            {3, "Unknown exceptions"},
            {4,"Age Is Less" }
        };

    }
}
