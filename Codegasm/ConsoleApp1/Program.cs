using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Random8Ball
{
    class Human
    {
        static public string name = "Jesse";
        static string alias = "jessegib";
        static public int age = 31;
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("We are about to begin...");
            Thread.Sleep(1500);
            Console.Beep(650, 2500);
            Thread.Sleep(1500);
            Console.WriteLine("Pick a number between 1 and 10");
            int keyInfo = int.Parse(Console.ReadLine());
            //I could you this in place of the int function
            //ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo <= 5 || keyInfo >= 7)
            {
                BackgroundColorChange();
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.SetWindowSize(90, 30);
                Console.SetCursorPosition(20, 10);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Congratulations! You have passed the first test.");
                Thread.Sleep(2000);
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("My name is {0}", Human.name);
                Thread.Sleep(2500);
                Console.SetCursorPosition(5, 15);
                Console.WriteLine("You are now entering my world of code. Do not be afraid for I will not hurt you.");
                Thread.Sleep(3000);
                Console.SetCursorPosition(5, 16);
                Console.WriteLine("However, you will be changed.");

                Console.SetCursorPosition(5, 18);
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("It is time for you to ask me a question.");
                Console.SetCursorPosition(20, 20);
                Console.WriteLine("+------------------------------------------------+");
                Console.SetCursorPosition(20, 21);
                Console.WriteLine("|                                                |");
                Console.SetCursorPosition(20, 23);
                Console.WriteLine("|                                                |");
                Console.SetCursorPosition(20, 24);
                Console.WriteLine("+------------------------------------------------+");
                

                //Creates a randomizer object
                Random randomObject = new Random();

                while (true)
                {
                    //This block of code will ask the user for a question and store the question
                    //text in questionString variable
                    Console.SetCursorPosition(21, 22);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    string questionString = Console.ReadLine();

                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();

                    if(questionString.ToLower() == "quit")
                    {
                        Console.SetCursorPosition(21, 22);
                        Thread.Sleep(2500);
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        EllipsisWrong();
                        break;
                    }

                    if(questionString.Length == 0)
                    {
                        Console.SetCursorPosition(21, 22);
                        Console.WriteLine("WHY HAVE YOU NOT ASKED ME A QUESTION?????");
                        Thread.Sleep(2500);
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();                        
                        continue;
                    }

                    if(questionString.ToLower() == "are you the greatest ever?")
                    {
                        EllipsisRight();
                        break;
                    }

                    int randomNumber = randomObject.Next(5);
                    switch(randomNumber)
                    {
                        case 0:
                            {
                                Console.SetCursorPosition(21, 22);
                                Console.WriteLine("You are correct.");
                                Thread.Sleep(2500);
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                ClearCurrentConsoleLine();
                                break;
                            }
                        case 1:
                            {
                                Console.SetCursorPosition(21, 22);
                                Console.WriteLine("You are not wrong.");
                                Thread.Sleep(2500);
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                ClearCurrentConsoleLine();
                                break;
                            }
                        case 2:
                            {
                                Console.SetCursorPosition(21, 22);
                                Console.WriteLine("Absolutely yes.");
                                Thread.Sleep(2500);
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                ClearCurrentConsoleLine();
                                break;
                            }
                        case 3:
                            {
                                Console.SetCursorPosition(21, 22);
                                Console.WriteLine("Umm, really??");
                                Thread.Sleep(2500);
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                ClearCurrentConsoleLine();
                                break;
                            }
                        case 4:
                            {
                                Console.SetCursorPosition(21, 22);
                                Console.WriteLine("I'll give you one more chance for a real question.");
                                Thread.Sleep(2500);
                                Console.SetCursorPosition(20, Console.CursorTop - 1);
                                ClearCurrentConsoleLine();
                                break;
                            }
                    

                    }
                }
            }
        }
        public static void EllipsisWrong()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, 12);
            Console.Write("You have chosen.");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.Write(".");
            Console.Write("Poorly\n");
            Thread.Sleep(1000);
            BackgroundColorChange();
        }

        public static void EllipsisRight()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, 12);
            Console.Write("You have chosen.");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(800);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.Write(".");
            Console.Write("Wisely\n");

            Console.Beep(658, 125);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        //A loop to make the color change back and forth when the number is guessed wrong
        static void BackgroundColorChange()
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Thread.Sleep(100);
                Console.Write("You are not ready!");
                //working on this
                
                Console.SetWindowSize(80, 20);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Beep(1000, 100);
                Console.Write("You are not ready!");
                
            }
        }
    }
}
