using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_Net_40_ADV01
{
    public class ContainerGeneric<T>  
    {
        public ContainerGeneric(T number1 )
        {
            Number1 = number1;
            
        }

        public T Number1 { get; set; } = default!;
        

        public  void Add(T _num) 
        {
          this.Number1 = _num;          
        }
        public T Get()
        {
            return this.Number1;
        }
        public override string ToString()
        {
            return $"Value : {this.Number1}";
        }
    }
}
