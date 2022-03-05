using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherApplication
{
    class Fibonacci
    {
        //max size: 4GB
        private UInt32 a;
        private UInt32 b; //b > a

        public void start(UInt32 a = 0, UInt32 b = 1)
        {
            this.a = a;
            this.b = b;
        }

        //value starts from 1
        public UInt32 next()
        {
            UInt32 temp = a;
            a = b;
            b = temp + b;
            return a; //return lower value
        }

        public UInt32 prev()
        {
            UInt32 temp = b;
            b = a;
            a = temp - a;
            return b; //return greater value
        }
    }
}
