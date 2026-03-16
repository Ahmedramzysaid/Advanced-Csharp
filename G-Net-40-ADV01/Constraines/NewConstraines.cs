using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Constraines
{
    public class NewConstraines<T> where T : new()
    {
        public NewConstraines() { }
        public T CreateInstance()
        {
            return new T();
        }
        public void Display()
        {
            Console.WriteLine($"Creating instance of type: {typeof(T).Name}");
        }


    }
}
