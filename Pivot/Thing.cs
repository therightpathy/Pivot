using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivot
{
    class Thing
    {
        public string name;
        public string keyword;
        public DateTime delivered;
        public DateTime returned;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Keyword
        {
            get { return keyword; }
            set { keyword = value; }
        }

        public DateTime Delivered
        {
            get { return delivered; }
            set { delivered = value; }
        }

        public DateTime Returned
        {
            get { return returned; }
            set { returned = value; }
        }
    }
}
