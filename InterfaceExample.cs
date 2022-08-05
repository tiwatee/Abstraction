using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExamples
{
    interface IIntegerCalc
    {
        public int IntegerProperty { get; set; }
        public int MethodAddition(int a, int b);
        public string MethodConc(string a, string b);
    }
}
