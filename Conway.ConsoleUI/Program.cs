using Conway.Library;
using System;
using System.Text;

namespace Conway.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new LifeGrid(25, 65);
            grid.Randomize();

            ShowGrid(grid.CurrentState);

            while (Console.ReadLine() != "q")
            {
                grid.UpdateState();
                ShowGrid(grid.CurrentState);
            }
        }

        private static void ShowGrid(CellState[,] currentState)
        {
            Console.Clear();
            int x = 0;
            int rowLength = currentState.GetUpperBound(1) + 1;

            var output = new StringBuilder();

            foreach (var state in currentState)
            {
                output.Append(state == CellState.Alive ? "O" : "·");
                x++;
                if (x >= rowLength)
                {
                    x = 0;
                    output.AppendLine();
                }
            }
            Console.Write(output.ToString());
        }

        // THIS WAS A SLOW DISPLAY ON LARGE GRIDS
        //private static void ShowGrid(CellState[,] currentState)
        //{
        //    Console.Clear();
        //    int x = 0;
        //    int rowLength = currentState.GetUpperBound(1) + 1;

        //    foreach (var state in currentState)
        //    {
        //        var output = state == CellState.Alive ? "O" : "·";
        //        Console.Write(output);
        //        x++;
        //        if (x >= rowLength)
        //        {
        //            x = 0;
        //            Console.WriteLine();
        //        }
        //    }
        //}
    }
}
