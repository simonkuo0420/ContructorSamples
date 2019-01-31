using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorSample002
{
    public class BaseClass
    {
        public int X { get; private set; }

        public BaseClass() : this(0) // this(0,0)
        { }

        public BaseClass(int y) // : this(x,0)
        {
            X = y;  // {  }
        }
        //public BaseClass(int x ,int y)
        //{
        //    X = x;
        //    y = y;
        //}
    }

    public class Class1 : BaseClass
    {
        public int K { get; set; }
        public Class1 (int x, int y) : base(y)
        {
            K = x;
        }
     
    }
}
