using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace CSharp_Programming_COP2360_228883_3
{
    class RandomValuesApp
    {
        private int _rows, _columns, _lgValue, _lgrow, _lgcol;
        private int[,] _2DPlane;
        public RandomValuesApp()
        {
            GetRows();
            GetColumns();
            Randomize2DPlane();
            RenderResults();
        }

        #region Assignment Menu 3-C

        private void GetRows()
        {
            while (true)
            {
                Clear();
                Write("How many rows do you want to create? ");

                int userInput;

                if (int.TryParse(ReadLine(), out userInput) && Enumerable.Range(0, 101).Contains(userInput))
                {
                    _rows = userInput;
                    break;
                }

                WriteLine("Invalid entry entered, please try again.");
                Program.AnyKeyContinue();
            }
        }

        private void GetColumns()
        {
            while (true)
            {
                Clear();
                WriteLine("How many rows do you want to create? {0}", _rows);
                Write("How many columns do you want to create? ");

                int userInput;

                if (int.TryParse(ReadLine(), out userInput) && Enumerable.Range(0, 101).Contains(userInput))
                {
                    _columns = userInput;
                    break;
                }

                WriteLine("Invalid entry entered, please try again.");
                Program.AnyKeyContinue();
            }
        }

        private void Randomize2DPlane()
        {
            _lgValue = 0;
            _2DPlane = new int[_rows,_columns];
            Random random = new Random();

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    var randint = random.Next(0, 101);
                    _2DPlane[i, j] = randint;
                    if (_lgValue < randint)
                    {
                        _lgValue = randint;
                        _lgrow = i + 1;
                        _lgcol = j + 1;
                    }
                }
            }
        }

        private void RenderResults()
        {
            WriteLine("\n\nRandom Generated Values\n");

            string columnHeader = "Col\t\t";

            for (int i = 0; i < _columns; i++)
            {
                columnHeader += $"{i + 1}\t";
            }

            WriteLine(columnHeader);

            for (int i = 0; i < _rows; i++)
            {
                Write("Row {0}\t\t", i + 1);
                for (int j = 0; j < _columns; j++)
                {
                    Write("{0}\t", _2DPlane[i, j]);
                }
                WriteLine();
            }

            WriteLine("Largest value: {0}", _lgValue);
            WriteLine("Row: {0}", _lgrow);
            WriteLine("Col {0}", _lgcol);
            ReadKey();
        }

        #endregion
    }
}
