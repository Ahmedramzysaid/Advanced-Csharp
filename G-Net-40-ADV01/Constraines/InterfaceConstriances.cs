using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Constraines
{
    public class InterfaceConstriances<T> where T : IComparable<T>
    {
        public InterfaceConstriances() { }

        public void Compare(T first, T second)
        {
            int result = first.CompareTo(second);
            if (result < 0)
            {
                Console.WriteLine($"{first} is less than {second}");
            }
            else if (result > 0)
            {
                Console.WriteLine($"{first} is greater than {second}");
            }
            else
            {
                Console.WriteLine($"{first} is equal to {second}");
            }
        }
    }
}
