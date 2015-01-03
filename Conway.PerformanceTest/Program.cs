using Conway.Library;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway.PerformanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new LifeGrid(75, 25);

            int iterations = 10000;

            Console.WriteLine("Number of iterations: {0}", iterations);

            grid.Randomize();
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
                grid.UpdateState();
            Console.WriteLine("Nested for: {0}ms", stopwatch.ElapsedMilliseconds);

            grid.Randomize();
            stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
                grid.UpdateState2();
            Console.WriteLine("Nested Parallel For: {0}ms", stopwatch.ElapsedMilliseconds);

            grid.Randomize();
            stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
                grid.UpdateState3();
            Console.WriteLine("Single Level Parallel For: {0}ms", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
