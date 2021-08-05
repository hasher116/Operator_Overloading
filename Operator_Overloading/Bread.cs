using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Bread
    {
        public int Weight { get; set; }
        public static Sandwitch operator +(Bread bread, Butter butter)
        {
            Sandwitch sandwitch = new Sandwitch();
            sandwitch.Weight = bread.Weight + butter.Weight;
            return sandwitch;
        }
    }

    class Butter
    {
        public int Weight { get; set; }
    }

    class Sandwitch
    {
        public int Weight { get; set; }
    }
}
