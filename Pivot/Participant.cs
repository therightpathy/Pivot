using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot
{
    class Participant
    {
        //Creating methods
        public string name;
        public string email;

        //Adding get&set to methods
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
