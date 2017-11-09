using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Startup
    {
        
        static void Main(string[] args)
        {
            int[,] table =
            {
                {0,4,0, 1,0,0 ,0,0,2 },
                {6,0,0, 0,0,4 ,0,0,0 },
                {0,0,5, 0,0,3 ,4,1,0 },

                {4,0,0, 5,0,0 ,1,0,0 },
                {0,0,8, 7,0,1 ,0,0,0 },
                {7,0,0, 0,8,0 ,5,4,3 },

                {1,0,9, 3,0,5 ,2,0,0 },
                {0,0,2, 0,0,0 ,6,3,0 },
                {0,3,0, 9,6,0 ,0,5,0 }
            };
            Console.WriteLine("SUDOKU TO SOLVE");
            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(" " + table[i,j]);
                }
                Console.WriteLine();
            }
            Sudoku.SolveSudoku(table);
            Sudoku.PrintSudoku(table);
        }
        
    }
}
