using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOfModifiers
{
    class Test
    {

        private int testVar1, testVar2;

        // default constructor
        public Test() { }

        // getter & setter

        public int TestVar1 { get; set; }
        public int TestVar2 { get; set; }


        public int Calculation()
        {
            int sum = TestVar1 + TestVar2;
            return sum;
        }


        

    }
}
