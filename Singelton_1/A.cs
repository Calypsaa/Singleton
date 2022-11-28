using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton_1
{
    public class A
    {
        private static A a;
        private static readonly object obj = new object();
        private A()
        {

        }

        public static A getInstance()
        {
            if (a == null)
            {
                lock (obj)
                {
                    if (a == null)
                    {
                        a = new A();
                    }

                }
            }
            return a;
        }
    }
}
