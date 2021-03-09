using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace labwork_3_5
{
    class Matrix
    {
        static object locker = new object();
        static Random rand = new Random();
        const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static void CreateString(object x)
        {
            int stringLength = rand.Next(5, Console.WindowHeight - 10);
            int pozX = (int)x; 
            int pozY = rand.Next(0, Console.WindowHeight - 2); 
            int currentY = 0; 

            for (int i = 0; i < stringLength; i++)
            {
                lock (locker)
                {
                    if (pozY == Console.WindowHeight - 1)
                    {
                        pozY = 0;
                        Console.SetCursorPosition(pozX, pozY);
                        currentY = pozY + 1;
                    }
                    else
                    {
                        Console.SetCursorPosition(pozX, pozY++);
                        currentY = pozY + 1;
                    }

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Letters.ToCharArray()[rand.Next(0, 35)]);

                    if (currentY > 3 && i >= 2)
                    {
                        Console.SetCursorPosition(pozX, currentY - 3);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Letters.ToCharArray()[rand.Next(0, 35)]);

                        Console.SetCursorPosition(pozX, currentY - 4);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(Letters.ToCharArray()[rand.Next(0, 35)]);
                    }
                    else if (currentY <= 2)
                    {
                        Console.SetCursorPosition(pozX, currentY - 4 + Console.WindowHeight);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Letters.ToCharArray()[rand.Next(0, 35)]);

                        Console.SetCursorPosition(pozX, currentY - 5 + Console.WindowHeight);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(Letters.ToCharArray()[rand.Next(0, 35)]);
                    }

                    if (i == stringLength - 1)
                    {
                        if (pozY >= stringLength)
                        {
                            Console.SetCursorPosition(pozX, pozY - stringLength);
                            Console.Write(' ');
                            i--;
                        }
                        else
                        {
                            Console.SetCursorPosition(pozX, Console.WindowHeight - stringLength + pozY);
                            Console.Write(' ');
                            i--;
                        }
                    }
                    Thread.Sleep(10);
                }
            }
        }
    }
}
