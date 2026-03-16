using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Constraines
{
    public  class  Parent
    {
               public void Display()
        {
            Console.WriteLine("This is the parent class.");
        }
    }
    public class BaseConstrainces<T> : Parent 
    {
        private T _value;
        public BaseConstrainces()
        {
            
        }
        public BaseConstrainces(T value)
        {
            _value = value;
        }
        public void Add(T value)
        {
            _value = value;
        }
        public T Get()
        {
            return _value;
        }
    }
}
