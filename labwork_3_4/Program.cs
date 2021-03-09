using System;
using System.Threading;

namespace labwork_3_4
{
    class Program
    {
        static void Go(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(Go);
            t.Name = "Поток " + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }
        private static void Main(string[] args)
        {
            Go(20);
            Console.ReadKey();
        }
    }
}

