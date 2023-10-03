using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    public class Cook : Employee
    {
        public Cook(int id, string name) : base(id, name)
        {

        }

        public override string ToString()
        {
            return $"Nazywam się {Name} i jestem kucharką.";
        }
    }
}
