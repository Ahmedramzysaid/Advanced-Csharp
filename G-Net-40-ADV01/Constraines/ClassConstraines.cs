using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Constraines
{
    public class ClassConstraines<T>  where T : class
    {
        
        private T _value;
        public ClassConstraines(T value)
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
