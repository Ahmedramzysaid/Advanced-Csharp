using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01.Interfaces
{
    public interface IRepository<T>
    {
        void Push(T item);
        T Pop(T item);
        T Peek();
        
    }
}
