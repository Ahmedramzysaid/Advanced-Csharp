using G_Net_40_ADV01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01
{
    public class StackGeneric : IRepository<string>
    {

         private   string[] _stack =  new string[10];
         private int _top = -1;
         int count = 0;
        public string? Peek()
        {
            if (count != 0) return null; 


            return  _stack[_top];

        }

        public string? Pop(string item)
        {
             if (count != 0) return null;
            return _stack[_top--];
        }

        public void Push(string item)
        {
            if (count >= 10) return; 
            _stack[++_top] = item;

        }
    }
}
