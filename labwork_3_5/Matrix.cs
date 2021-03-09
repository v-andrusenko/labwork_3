using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace labwork_3_5
{
    class Matrix
    {
        private static object locker = new object();
        private Random rand;
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public int Column { get; set; }
        public bool NextOne { get; set; }

        public Matrix(int column, bool nextOne)
        {
            Column = column;
            rand = new Random((int)DateTime.Now.Ticks);
            NextOne = nextOne;
        }

        private char Sign => letters.ToCharArray()[rand.Next(0, 35)];

        public void Moving()
        {
            int lenght;
            int counter;

            while (true)
            {
                counter = rand.Next(3, 12);
                lenght = 0;
                Thread.Sleep(rand.Next(20, 5000));
                for (int i = 0; i < 40; i++)
                {
                    lock (locker)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.CursorTop = i - lenght;

                        for (int j = i - lenght; j < i; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine("---");
                        }

                        if (lenght < counter)
                            lenght++;
                        else if (lenght == counter)
                            counter = 0;

                        if (NextOne && i < 20 && i > lenght + 2 && (rand.Next(1, 5) == 3))
                        {
                            new Thread((new Matrix(Column, false)).Moving).Start();
                            NextOne = false;
                        }

                        if (39 - i < lenght)
                            lenght--;

                        Console.CursorTop = i - lenght + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        for (int j = 0; j < lenght - 2; j++)
                        {
                            Console.CursorLeft = Column;
                            Console.WriteLine(Sign);
                        }

                        if (lenght >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Column;
                            Console.WriteLine(Sign);
                        }

                        if (lenght >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Column;
                            Console.WriteLine(Sign);
                        }

                        Thread.Sleep(10);

                    }
                }
            }
        }
    }
}
