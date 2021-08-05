using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }

        public static State operator +(State state1, State state2)
        {
            State state3 = new State();
            state3.Area = state1.Area + state2.Area;
            state3.Population = state1.Population + state2.Population;
            return state3;
        }
        public static bool operator >(State state1, State state2)
        {
            return state1.Area > state2.Area;
        }
        public static bool operator <(State state1, State state2)
        {
            return state1.Area < state2.Area;
        }
    }
}
