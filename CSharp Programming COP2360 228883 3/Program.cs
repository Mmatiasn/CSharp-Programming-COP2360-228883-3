using System;
using static System.Console;

///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_3>                              
///   Class:          <Class Program>                                   
///   Description:    <Description Assignment 3>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 02/27/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                              
///   Name:Initial  Date:02/27/2017 Description:Last Modification Date                  
///------------------------------------------------------------------------------

namespace CSharp_Programming_COP2360_228883_3
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Intro();
        }

        internal static void Assignment3Art()
        {
            WriteLine("  ___          _                                  _     _____ ");
            WriteLine(" / _ \\        (_)                                | |   |____ |");
            WriteLine("/ /_\\ \\___ ___ _  __ _ _ __  _ __ ___   ___ _ __ | |_      / /");
            WriteLine("|  _  / __/ __| |/ _` | '_ \\| '_ ` _ \\ / _ \\ '_ \\| __|     \\ \\");
            WriteLine("| | | \\__ \\__ \\ | (_| | | | | | | | | |  __/ | | | |_  .___/ /");
            WriteLine("\\_| |_/___/___/_|\\__, |_| |_|_| |_| |_|\\___|_| |_|\\__| \\____/ ");
            WriteLine("                  __/ |                                       ");
            WriteLine("                 |___/                                        ");
        }

        internal static void Intro(ConsoleColor textColor = ConsoleColor.Green, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Title = typeof(Program).Namespace;
            ForegroundColor = textColor;
            BackgroundColor = backgroundColor;
            Clear();
            Assignment3Art();
            WriteLine();
            WriteLine("Welcome to the assignment 3 application\n");
            WriteLine("Press any key when you are ready to begin...");
            ReadKey();
            AssignmentMenu();
        }

        #region Main Assignment Menu
        internal static void AssignmentMenu()
        {
            Clear();
            Assignment3Art();
            WriteLine();
            WriteLine("Assignment 3-A   | enter \"A\"");
            WriteLine("Assignment 3-B   | enter \"B\"");
            WriteLine("Assignment 3-C   | enter \"C\"");
            WriteLine("Exit Application | enter \"E\"");
            WriteLine();
            Write("Take me to assignment: ");
            AssignmentMenu(ReadKey());
        }

        internal static void AssignmentMenu(ConsoleKeyInfo userKeyInfo)
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
        internal static void IntroA()
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
        internal static void AssignmentA()
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

        internal static void AssignmentMenuA(ConsoleKeyInfo userKeyInfo)
        {

        }
        #endregion

        #region Assignment Menu 3-B
        internal static void AssignmentMenuB()
        {

        }

        internal static void AssignmentMenuB(ConsoleKeyInfo userKeyInfo)
        {

        }
        #endregion

        #region Assignment Menu 3-C
        internal static void AssignmentMenuC()
        {

        }

        internal static void AssignmentMenuC(ConsoleKeyInfo userKeyInfo)
        {

        }
        #endregion

        #region Common
        internal static void ExitApplication()
        {
            Clear();
            WriteLine("Application will now close\n");
            AnyKeyContinue();
        }

        internal static void AnyKeyContinue()
        {
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
        #endregion
    }
}
