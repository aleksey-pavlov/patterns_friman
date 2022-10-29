using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    class Duck : IComparable<Duck>
    {
        int Size;
        string Name;

        public Duck (int size, string name)
        {
            Size = size;
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        // Template method
        public int CompareTo(Duck other)
        {
            if (Size > other.Size)
                return -1;
            else if (Size < other.Size)
                return 1;

            return 0;
        }
    }
}
