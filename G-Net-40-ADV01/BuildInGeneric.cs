using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01
{
    public   class BuildInGeneric
    {
         public  static  void Swap<T>( ref T V1 ,  ref T v2)
        {
            T temp = V1; 
            V1  =  v2; 
            v2 = temp;   
        }
        public static T FindMax<T>(T[] arrOfList) where T : IComparable<T>
        {
            T MaxValue = arrOfList[0];

            foreach (T item in arrOfList) {
                     if(MaxValue.CompareTo(item) < 0) MaxValue = item;
            }

            return MaxValue;
        }
    }
}
