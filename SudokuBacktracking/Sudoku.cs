using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Sudoku
    {
        public static bool SolveSudoku(int[,] table, int row = 0, int col = 0)
        {
            if (col == 9)
            {
                row++;
                col = 0;

                if (row == 9)
                {
                    return true;
                }
            }

            if (table[row, col] > 0)
            {
                return SolveSudoku(table, row, col + 1);
            }

            for (int i = 1; i <= 9; ++i)
            {

                bool isOk = true;
                for (int l = 0; l < 9; ++l)
                {
                    if (table[row, l] == i || table[l, col] == i ||
                        table[row / 3 * 3 + l / 3, col / 3 * 3 + l % 3] == i)
                    {
                        isOk = false;
                        break;
                    }
                }
                if (!isOk) continue;

                table[row, col] = i;
                if (SolveSudoku(table, row, col + 1))
                {
                    return true;
                }

                table[row, col] = 0;
            }
            return false;
        }

        public static void PrintSudoku(int[,] table)
        {
            Console.WriteLine();
            Console.WriteLine("SUDOKU SOLVED");
            Console.WriteLine();
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    Console.Write(" " + table[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
