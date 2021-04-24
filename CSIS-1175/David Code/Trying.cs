using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Code
{
    class Trying
    {
        private int test1, test2, test3, test4;
        int test5 = 10;

       /*
        Constants
       Variables
       Public const
       Public param const
       get and set
       array get and set
       methods
       tostring
        */

        /*
         * Arrays getter setter
         public int GetCredit(int index)
            return credit[index];
        public void SetCredit(int value, int index)
            credit[index] = value;
         */

        //default constructor
        public Trying() { }

        public Trying(int te1, int te2, int te3)
        {
            test1 = te1;
            test2 = te2;
            test3 = te3;
        }
        
        /*
         public int a
        {
            get {return value;}
        set { a = value;}
        }
         */


        //getter setter
        public int Test1 { get; set; }
        public int Test2 { get; set; }
        public int Test3 { get; set; }
        public int Test4 
        { 
            set { test4 = value; }
        }
        public int Test5 
        { 
            get { return test5; }
        }


        public int SumCalculator()
        {
            int sum = Test1 + Test2 + Test3;
            return sum;
        }




    }
}
