using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class NumberOneException:Exception
    {
        public NumberOneException(string message):base(message) { }
    }
}
