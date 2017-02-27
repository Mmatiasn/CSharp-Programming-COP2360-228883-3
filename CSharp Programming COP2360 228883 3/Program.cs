using System;
using static System.Console;

#pragma warning disable 1587
///------------------------------------------------------------------------------
///   Namespace:      <Class CSharp_Programming_COP2360_228883_3>                              
///   Class:          <Class Program>                                   
///   Description:    <Description Assignment 3>                                  
///   Author:         <Author Matias Miranda Noriega> Date: <DateTime 02/27/2017>   
///   Notes:          <Notes>                                        
///   Revision History:                                              
///   Name:Initial  Date:02/27/2017 Description:Last Modification Date                  
///------------------------------------------------------------------------------
#pragma warning restore 1587

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
                    var assignmentA = new IsoscelesTriangleApp();
                    AssignmentMenu();
                    break;
                case ConsoleKey.B:
                    var assignmentB = new ParallelArrayApp();
                    AssignmentMenu();
                    break;
                case ConsoleKey.C:
                    var assignmentC = new RandomValuesApp();
                    AssignmentMenu();
                    break;
                case ConsoleKey.E:
                    ExitApplication();
                    break;
                default:
                    WriteLine("\nInvalid selection entered: {0}", userKeyInfo.KeyChar);
                    AnyKeyContinue();
                    AssignmentMenu();
                    break;
            }
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
            WriteLine("Press any key to continue...");
            ReadKey();
        }
        #endregion
    }
}
