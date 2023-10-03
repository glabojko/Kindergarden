using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    internal class Kid
    {
        string FirstName { get; set; }
        int Age { get; set; }
        public Kid(string firstName, int age)
        {
            FirstName = firstName;
            Age = age;
        }

        public override string ToString()
        {
            return $"Nazywam się {FirstName} i pokazuję Ci {Age} palców";
        }
    }
}

