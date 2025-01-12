using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05._ٍSealed
{
    internal  sealed class ImuttableString
    {
        private readonly string value;
        public string Value { get { return value; } }   
        public ImuttableString(string value)
        {
            this.value = value;
        }
    }
}
