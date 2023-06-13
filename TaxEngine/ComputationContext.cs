using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleClassLibrary.Chapter2
{
    public class ComputationContext
    {
        protected readonly Dictionary<string, object> _symbols = new();
        public void Put(string k, object value)
        {
            _symbols.Add(k, value);
        }
        public object Get(string k)
        {
            return _symbols[k];
        }
    }
}
