using System;
using System.Linq;
using static System.Console;

namespace CSharp_Programming_COP2360_228883_3
{
    class IsoscelesTriangleApp
    {
        private string _character;
        private int _integer;

        public IsoscelesTriangleApp()
        {
            Intro();
        }

        #region Assignment 3-A

        private void Intro()
        {
            Clear();
            WriteLine("------------------------------------------------------------------");
            WriteLine("----     You will be prompted to enter a character to be      ----");
            WriteLine("----     used for printing an isosceles triangle AND an       ----");
            WriteLine("----     integer between 1 and 10.                            ----");
            WriteLine("----     The integer will be the length for the two sides     ----");
            WriteLine("----     of the isosceles triangle. Whatever character is     ----");
            WriteLine("----     entered will be the character used for printing.     ----");
            WriteLine();
            WriteLine("----     You will be able to enter as many sets as you wish.  ----");
            WriteLine("------------------------------------------------------------------");
            WriteLine();
            WriteLine("\t Press any key when you are ready to begin...");
            ReadKey();
            IntergerInput();
        }

        private void IntergerInput()
        {
            Clear();
            WriteLine("How large of an isosceles Triangle do you want to print?");
            Write("Please enter a positive integer (between 1 and 10) : ");

            int userInput;

            if (int.TryParse(ReadLine(), out userInput) && Enumerable.Range(1, 10).Contains(userInput))
            {
                _integer = userInput;
                CharacterInput(_integer);
            }
            else
            {
                _integer = 3;
                WriteLine("\nInvalid entry entered, the default value of 3 will be used.");
                Program.AnyKeyContinue();
                CharacterInput(_integer);
            }
        }

        private void CharacterInput(int interger)
        {
            Clear();
            WriteLine("How large of an isosceles Triangle do you want to print?");
            WriteLine("Please enter a positive integer (between 1 and 10) : {0}", interger);
            Write("What character do you want to use for printing? ");

            var userInput = ReadKey().KeyChar.ToString();

            if (userInput != "\0" && userInput != "\t" && userInput != "\r")
            {
                _character = userInput;
                WriteLine("\nPress any key to render triangle...");
                ReadKey();
                Clear();
                RenderTriangle(_integer, _character);
            }
            else
            {
                _character = "*";
                WriteLine("\n\nInvalid entry entered, the default value of * will be used.");
                WriteLine("Press any key to render triangle...");
                ReadKey();
                RenderTriangle(_integer, _character);
            }
        }

        private void RenderTriangle(int interger, string character)
        {
            Clear();
            for (int i = 0; i < interger; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Write(_character);
                }
                WriteLine();
            }
            for (int i = interger - 1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Write(_character);
                }
                WriteLine();
            }

            WriteLine("\nWould you like to enter a new character and size?");
            WriteLine("Please enter 'y' for yes or any other letter for no: ");

            var userInput = ReadKey();

            switch (userInput.Key)
            {
                case ConsoleKey.Y:
                    IntergerInput();
                    break;
                default:
                    WriteLine("\nNavigating back to main menu...");
                    Program.AnyKeyContinue();
                    break;
            }
        }

        #endregion
    }
}
