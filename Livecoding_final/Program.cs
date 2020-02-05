using System;
using System.Collections.Generic;

namespace Livecoding_final
{
    class Program
    {

        private static readonly int avg = 250*3;

        private static Dictionary<string, int> Weather = new Dictionary<string, int>() { {"Clear", 10 }, {"Cloudy", 0 }, {"Rainy", -25}, {"Full moon", 25} };
        private static Dictionary<string, int> Temperature = new Dictionary<string, int>() { { "40s", -5}, { "50s", 0}, { "60s", 5}, { "70s", 20} };

        static double CandyCount(string weather, string temperature)
        {

            double candy = avg + avg * (double)(Weather[weather] + Temperature[temperature])/100;

            return candy;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CandyCount("Clear","50s"));
        }
    }
}
