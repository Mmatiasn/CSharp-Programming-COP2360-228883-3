using System;
using static System.Console;

namespace CSharp_Programming_COP2360_228883_3
{
    public static class Display
    {
        public static void Intro(ConsoleColor textColor = ConsoleColor.Green, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Title = typeof(Display).Namespace;
            ForegroundColor = textColor;
            BackgroundColor = backgroundColor;
            Clear();
            WriteLine("  ___          _                                  _     _____ ");
            WriteLine(" / _ \\        (_)                                | |   |____ |");
            WriteLine("/ /_\\ \\___ ___ _  __ _ _ __  _ __ ___   ___ _ __ | |_      / /");
            WriteLine("|  _  / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __|     \\ \\");
            WriteLine("| | | \\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_  .___/ /");
            WriteLine("\\_| |_/___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__| \\____/ ");
            WriteLine("                  __/ |                                       ");
            WriteLine("                 |___/                                        ");
            WriteLine();
            WriteLine("Welcome to the assignment 3 application\n");
            WriteLine("Press any key when you are ready to begin...");
            ReadKey();
            AssignmentMenu();
        }

        #region Main Assignment Menu
        public static void AssignmentMenu()
        {
            Clear();
            WriteLine("  ___          _                                  _     _____ ");
            WriteLine(" / _ \\        (_)                                | |   |____ |");
            WriteLine("/ /_\\ \\___ ___ _  __ _ _ __  _ __ ___   ___ _ __ | |_      / /");
            WriteLine("|  _  / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __|     \\ \\");
            WriteLine("| | | \\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_  .___/ /");
            WriteLine("\\_| |_/___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__| \\____/ ");
            WriteLine("                  __/ |                                       ");
            WriteLine("                 |___/                                        ");
            WriteLine();
            WriteLine("Assignment 3-A   | enter \"A\"");
            WriteLine("Assignment 3-B   | enter \"B\"");
            WriteLine("Assignment 3-C   | enter \"C\"");
            WriteLine("Exit Application | enter \"E\"");
            WriteLine();
            Write("Take me to assignment: ");
            AssignmentMenu(ReadKey());
        }

        public static void AssignmentMenu(ConsoleKeyInfo userKeyInfo)
        {
            switch (userKeyInfo.Key)
            {
                case ConsoleKey.A:
                    IntroA();
                    break;
                case ConsoleKey.B:
                    //IntroB();
                    break;
                case ConsoleKey.C:
                    //IntroC();
                    break;
                case ConsoleKey.E:
                    ExitApplication();
                    break;
                default:
                    WriteLine("\nInvalid selection entered: {0}", userKeyInfo.KeyChar.ToString());
                    AnyKeyContinue();
                    AssignmentMenu();
                    break;
            }
        }
        #endregion

        #region Assignment 3-A
        public static void IntroA()
        {
            Clear();
            WriteLine("------------------------------------------------------------------");
            WriteLine("----     You will be prompted to enter a character to be      ----");
            WriteLine("----     used for printing an isosceles triangle AND an       ----");
            WriteLine("----     interger between 1 and 10.                           ----");
            WriteLine("----     The interger will be the length for the two sides    ----");
            WriteLine("----     of the isosceles triangle. Whatever character is     ----");
            WriteLine("----     entered will be the character used for printing.     ----");
            WriteLine();
            WriteLine("----     You will be able to enter as many sets as you wish.  ----");
            WriteLine("------------------------------------------------------------------");
            WriteLine();
            WriteLine("\t Press any key when you are ready to begin...");
            ReadKey();
            AssignmentA();
        }
        public static void AssignmentA()
        {
            Clear();
            WriteLine("How large of an isoceles Triangle do you want to print?");
            Write("Please enter a positive interger (between 1 and 10) : ");

            int userInput;

            if (int.TryParse(ReadLine(), out userInput))
            {

            }
            else
            {
                WriteLine("\n LOL NOPE");
                AssignmentA();
            }
        }

        public static void AssignmentMenuA(ConsoleKeyInfo userKeyInfo)
        {

        }
        #endregion

        #region Assignment Menu 3-B
        public static void AssignmentMenuB()
        {

        }

        public static void AssignmentMenuB(ConsoleKeyInfo userKeyInfo)
        {

        }
        #endregion

        #region Assignment Menu 3-C
        public static void AssignmentMenuC()
        {

        }

        public static void AssignmentMenuC(ConsoleKeyInfo userKeyInfo)
        {

        }
        #endregion

        #region Common
        public static void ExitApplication()
        {
            Clear();
            WriteLine("Application will now close\n");
            AnyKeyContinue();
        }

        public static void AnyKeyContinue()
        {
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
        #endregion
    }
}
