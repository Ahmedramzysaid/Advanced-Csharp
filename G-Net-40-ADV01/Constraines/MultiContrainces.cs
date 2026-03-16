using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Constraines
{
    public class MultiContrainces<T> where T : struct, IComparable<T>
    {
        public MultiContrainces() { }

        public void Display()
        {
            Console.WriteLine($"Type: {typeof(T).Name}");
        }
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
