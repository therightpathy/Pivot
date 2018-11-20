using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot
{
    class Project
    {
        //Creating methods 
        public string name;
        public string description;

        public Project()
        {
        }

        //Creating default constructor to inherit from Participant class
        public Project(string name, string email)
        {           
        }

        //Adding get&set to methods
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
