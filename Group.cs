using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    public class Group
    {
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }
        public int GroupStartAge { get; set; }
        public Teacher Teacher { get; set; }

        public Group(int groupNumber,  string groupName, Teacher teacher)
        {
            GroupNumber = groupNumber;
            GroupName = groupName;
            GroupStartAge = groupNumber + 2;
            Teacher = teacher;
        }
    }
}
