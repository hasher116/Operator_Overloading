using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Counter
    {
        public static Counter operator +(Counter c1, Counter c2)
        {
            Counter c3 = new Counter();
            c3.Value = c1.Value + c2.Value;
            return c3;
        }
        public static Counter operator +(Counter c1, int f)
        {
            Counter c3 = new Counter();
            c3.Value = c1.Value + f;
            return c3;
        }

        public static Counter operator -(Counter c1, Counter c2)
        {
            Counter c3 = new Counter();
            c3.Value = c1.Value - c2.Value;
            return c3;
        }
        public static Counter operator -(Counter c1, int f)
        {
            c1.Value -= f;
            return c1;
        }

        public static Counter operator ++(Counter c1)
        {
            c1.Value += 10;
            return c1;
        }

        public static bool operator !=(Counter c1, Counter c2)
        {
            return (c1.Value != c2.Value);
        }
        public static bool operator ==(Counter c1, Counter c2)
        {
            return (c1.Value == c2.Value);
        }
        public int Value { get; set; }
    }
}
