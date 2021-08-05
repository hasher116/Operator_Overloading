using System;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter count1 = new Counter();
            count1.Value = 24;

            Counter count2 = new Counter();
            count2.Value = 25;

            Console.WriteLine((++count2).Value);



            State belarus = new State();
            belarus.Area = 207.6M;
            belarus.Population = 9349645M;
            State russia = new State();
            russia.Area = 17125.2M;
            russia.Population = 146171015M;
            State belarussia = belarus + russia;
            bool isGreater = belarus > russia;
            Console.WriteLine($"Население = {belarussia.Population}, Площадь = {belarussia.Area}\nБеларусь является больше России - {isGreater} ");

            Bread bread = new Bread();
            bread.Weight = 80;
            Butter butter = new Butter();
            butter.Weight = 20;
            Sandwitch sandwitch = new Sandwitch();
            sandwitch = bread + butter;
            Console.WriteLine(sandwitch.Weight);
        }
    }
}
