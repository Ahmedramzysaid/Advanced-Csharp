using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01
{
    internal class Pairs<TKey, TValue>
    {
        public Pairs(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public void Add(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value; 
        }
        public TValue getValue(TKey key)
        {
            return this.Value;
        }
        public override string ToString()
        {
            return $"Key {this.Key} , Value : {this.Value}"; 
        }


    }
}
