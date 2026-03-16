using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Constraines
{
    public class StuctConstraines<T> where T : struct
    {
            private T _value;
            public StuctConstraines(T value)
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
