using System;
using System.Threading;

namespace labwork_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < Console.WindowWidth - 1;)
            {
                new Thread(new ParameterizedThreadStart(Matrix.CreateString)).Start((object)i);
                i += 2;
            }
        }
    }
}
