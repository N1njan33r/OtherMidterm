using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of columns: ");
            string columns = Console.ReadLine();
            Console.Write("Enter number of rows: ");
            string rows = Console.ReadLine();
            Grid grid = new Grid(columns, rows);

            Console.Clear();
            //Console.WriteLine($"Grid is {grid.Columns} columns by {grid.Rows} rows.");

            grid.DrawGrid(grid.Columns, grid.Rows);

            Console.ReadKey();
        }
    }

    class Grid
    {
        public int Columns { get; set; }
        public int Rows { get; set; }

        public Grid(string _columns, string _rows)
        {
            if (int.TryParse(_columns, out int col) && int.TryParse(_rows, out int row))
            {
                Columns = col;
                Rows = row;
            }
            else
            {
                Console.WriteLine("Parsing error.");
            }
        }

        public void DrawGrid(int _columns, int _rows)
        {
            int i;
            int j;
            int colHeader = 0;
            int rowHeader = 1;
            for (i = 0; i < _rows + 1; i++)
            {
                for (j = 0; j < _columns + 1; j++)
                {
                    if (i == 0)
                    {
                        if (colHeader == 0)
                        {
                            Console.Write(" X");
                        }
                        else
                        {
                            Console.Write(" " + colHeader);
                        }
                        colHeader++;
                    }
                    else if (j == 0)
                    {
                        Console.Write(" " + rowHeader);
                        rowHeader++;
                    }
                    else
                    {
                        Console.Write(" ■");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
