﻿using System;
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

        private List<Kid> KidsList;

        public Group(int groupNumber,  string groupName, Teacher teacher)
        {
            GroupNumber = groupNumber;
            GroupName = groupName;
            GroupStartAge = groupNumber + 3;
            Teacher = teacher;
            KidsList = new List<Kid>();
        }

        public void AddKidToGroup(Kid kid)
        {
            KidsList.Add(kid);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Kid kid in KidsList)
            {
                sb.AppendLine(kid.ToString());
            }  
            return sb.ToString();
        }

    }
}
